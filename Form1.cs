using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FftSharp;
using Microsoft.WindowsAPICodePack.Dialogs;
using NAudio.Wave;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace smanip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InstrumentObj = new Instrument(this);

            InitializeComponent();
        }

        public string SrcDir = "";
        public bool   SrcDirValid;

        public string DstDir = "";
        public bool   DstDirValid;

        public string ConfigFileDst => Path.Combine(DstDir, "config.json");
        public string ConfigFileSrc => Path.Combine(SrcDir, "config.json");

        public string SrcFile = "";
        public bool   SrcFileValid;

        public static Color ColorGreen  = Color.DarkGreen;
        public static Color ColorRed    = Color.DarkRed;
        public static Color ColorBlue   = Color.RoyalBlue;
        public static Color ColorPurple = Color.Purple;
        public static Color ColorYellow = Color.DarkGoldenrod;

        public const string STATE_VALID      = "Valid ✔";
        public const string STATE_INVALID    = "Invalid ✖";
        public const string STATE_TOOL_ERROR = "Tool error ✖";
        public const string STATE_SUCCESS    = "Success ✔";

        public const char PATTERN_ANY_CHAR        = '*';
        public const char PATTERN_ESCAPE_SEQUENCE = '%';
        public const char PATTERN_ESCAPE_NOTE     = 'n';
        public const char PATTERN_ESCAPE_OCTAVE   = 'o';
        public const char PATTERN_ESCAPE_VELOCITY = 'v';

        [Serializable]
        public class Instrument
        {
            public string                                  Name;
            public string                                  SoundType;
            public float                                   FadeForced = 1;
            public bool                                    Loop;
            public Dictionary<int, Dictionary<int, int[]>> LoopInfo = new Dictionary<int, Dictionary<int, int[]>>();

            public readonly BitArray NoteExists = new BitArray(61);

            public Form1  FormObj;
            public string DstDir        => FormObj.DstDir;
            public string SrcDir        => FormObj.SrcDir;
            public string ConfigFileDst => Path.Combine(DstDir, "config.json");
            public string ConfigFileSrc => Path.Combine(SrcDir, "config.json");

            public Instrument(Form1 pForm)
            {
                FormObj = pForm;
            }

            public void AutofillDst()
            {
                Name      = Path.GetFileName(DstDir);
                SoundType = "attack";
            }

            public void AutofillSrc()
            {
                Name      = Path.GetFileName(SrcDir);
                SoundType = "attack";
            }

            public void RefreshNoteStates()
            {
                if (!Directory.Exists(DstDir))
                {
                    NoteExists.SetAll(false);
                    return;
                }

                var files = Directory.GetFiles(DstDir);
                for (var i = 0; i < 61; i++)
                {
                    NoteExists.Set(i, files.Any(p => Path.GetFileName(p).StartsWith((i + 24).ToString())));
                }
            }

            public void SaveЈson()
            {
                dynamic json = new ExpandoObject();

                json.name       = Name;
                json.soundType  = SoundType;
                json.fadeForced = FadeForced;

                if (Loop)
                {
                    json.loopInfo       = new ExpandoObject();
                    json.loopInfo.notes = LoopInfo;
                }
                else
                {
                    json.loopInfo = null;
                }

                File.WriteAllText(ConfigFileDst, JsonConvert.SerializeObject(json, Formatting.Indented));
            }

            public void FromJson(bool pSrc)
            {
                dynamic json = JsonConvert.DeserializeObject(File.ReadAllText(pSrc ? ConfigFileSrc : ConfigFileDst));

                Name       = json.name;
                SoundType  = json.soundType;
                FadeForced = json.fadeForced;

                Loop = SoundType.Contains("loop");
                if (Loop)
                {
                    LoopInfo = ((JObject)json.loopInfo.notes).ToObject<Dictionary<int, Dictionary<int, int[]>>>();
                }
            }

            public bool HasAllNotes()
            {
                RefreshNoteStates();
                return NoteExists.Cast<bool>().All(p => p);
            }
        }

        public Instrument InstrumentObj;

        public static class DirType
        {
            public const int INVALID = 1 << 0;
            public const int WAV     = 1 << 1;
            public const int NCW     = 1 << 2;

            public static Tuple<Color, string> Repr(int p)
            {
                var c = ColorRed;
                var s = "NULL";

                if ((p & INVALID) != 0)
                {
                    c = ColorRed;
                    s = STATE_INVALID;
                }

                if ((p & WAV) != 0 && (p & NCW) != 0)
                {
                    c = ColorPurple;
                    s = "WAV & NCW";
                }
                else if ((p & WAV) != 0)
                {
                    c = ColorGreen;
                    s = "WAV";
                }
                else if ((p & NCW) != 0)
                {
                    c = ColorBlue;
                    s = "NCW";
                }


                return new Tuple<Color, string>(c, s);
            }
        }

        public void SetColorAndText(Control p, Tuple<Color, string> pData)
        {
            p.ForeColor = pData.Item1;
            p.Text      = pData.Item2;
        }

        public int SrcDirType = DirType.INVALID;

        public int GetDirType(string pDir)
        {
            var ret   = 0;
            var files = Directory.GetFiles(pDir);

            if (files.Any(p => p.EndsWith(".wav")))
            {
                ret |= DirType.WAV;
            }

            if (files.Any(p => p.EndsWith(".ncw")))
            {
                ret |= DirType.NCW;
            }

            return ret == 0 ? DirType.INVALID : ret;
        }

        public void GenerateInstrumentGui()
        {
            if (groupBoxInstrument.Enabled)
            {
                textBoxInstrumentName.Text = InstrumentObj.Name;

                var allNotes = InstrumentObj.HasAllNotes();
                labelNoteStatus.Text      = allNotes ? "All notes present ✔" : "Missing notes ✖";
                labelNoteStatus.ForeColor = allNotes ? ColorGreen : ColorRed;
            }
        }

        public int GetSrcDirType()
        {
            if (!SrcDirValid)
            {
                SetColorAndText(labelFormat, DirType.Repr(DirType.INVALID));
                return DirType.INVALID;
            }

            SrcDirType = GetDirType(SrcDir);
            SetColorAndText(labelSrcType, DirType.Repr(SrcDirType));

            if (SrcDirType == DirType.INVALID)
            {
                SetColorAndText(labelFormat, DirType.Repr(DirType.INVALID));
            }

            buttonConvertNcwToWav.Enabled = (SrcDirType & DirType.NCW) != 0;
            groupBoxWav.Enabled           = SrcDirType == DirType.WAV;

            if (!File.Exists(ConfigFileSrc))
            {
                InstrumentObj.AutofillSrc();
            }

            return SrcDirType;
        }

        public void ValidateSrcDir()
        {
            SrcDir                     = textBoxSrcDir.Text;
            SrcDirValid                = Directory.Exists(SrcDir);
            labelSrcDirValid.Text      = SrcDirValid ? STATE_VALID : STATE_INVALID;
            labelSrcDirValid.ForeColor = SrcDirValid ? ColorGreen : ColorYellow;

            groupBoxSrcDir.Enabled = SrcDirValid;

            var srcDirType = GetSrcDirType();
            groupBoxWav.Enabled = srcDirType != DirType.INVALID;
            if (!SrcDirValid || srcDirType == DirType.INVALID || srcDirType == DirType.NCW)
            {
                return;
            }

            if (File.Exists(ConfigFileSrc))
            {
                InstrumentObj.FromJson(true);
                groupBoxInstrument.Enabled = true;
                GenerateInstrumentGui();
            }

            var correctFormat = true;
            var noneWav       = true;
            foreach (var file in Directory.GetFiles(SrcDir))
            {
                if (Path.GetExtension(file) != ".wav")
                {
                    continue;
                }

                noneWav = false;

                var name = Path.GetFileNameWithoutExtension(file);
                if (name.Count(p => p == '_') != 1)
                {
                    correctFormat = false;
                    break;
                }

                var parts = name.Split('_');
                if (!(int.TryParse(parts[0], out _) && int.TryParse(parts[1], out _)))
                {
                    correctFormat = false;
                    break;
                }
            }

            correctFormat &= !noneWav;

            labelFormat.Text      = correctFormat ? "Correct format ✔" : "Files need renaming ✖";
            labelFormat.ForeColor = correctFormat ? ColorGreen : ColorYellow;
        }

        public void ValidateDstDir()
        {
            DstDir                     = textBoxDstDir.Text;
            DstDirValid                = Directory.Exists(DstDir);
            labelDstDirValid.Text      = DstDirValid ? STATE_VALID : STATE_INVALID;
            labelDstDirValid.ForeColor = DstDirValid ? ColorGreen : ColorRed;

            if (DstDirValid)
            {
                if (File.Exists(ConfigFileDst))
                {
                    InstrumentObj.FromJson(false);
                }
                else
                {
                    InstrumentObj.AutofillDst();
                    InstrumentObj.SaveЈson();
                }
            }

            groupBoxInstrument.Enabled = DstDirValid && File.Exists(ConfigFileDst);
            GenerateInstrumentGui();
        }

        public void ValidateSrcFile()
        {
            SrcFile                     = textBoxSrcFile.Text;
            SrcFileValid                = File.Exists(SrcFile);
            labelSrcFileValid.Text      = SrcFileValid ? STATE_VALID : STATE_INVALID;
            labelSrcFileValid.ForeColor = SrcFileValid ? ColorGreen : ColorRed;

            buttonExtract.Enabled = SrcFileValid;
        }

        public void ValidateRun()
        {
            var pattern = textBoxPattern.Text;
            if (pattern.Length == 0)
            {
                buttonRun.Enabled = false;
                return;
            }

            if (!DstDirValid)
            {
                buttonRun.Enabled = false;
                return;
            }

            if (!pattern.Contains(PATTERN_ESCAPE_SEQUENCE + "n"))
            {
                buttonRun.Enabled = false;
                return;
            }

            buttonRun.Enabled = true;
        }

        public string WavFileNameEncode(int pSemitones, int pVelocity)
        {
            return $"{pSemitones}_{pVelocity}.wav";
        }

        public (int, int)? ParseWavFileName(string pFile)
        {
            var name        = Path.GetFileNameWithoutExtension(pFile);
            var underscores = name.Count(p => p == '_');
            switch (underscores)
            {
                case 1:
                {
                    var parts = name.Split('_');

                    if (!int.TryParse(parts[0], out var semitones))
                    {
                        return null;
                    }

                    if (!int.TryParse(parts[1], out var velocity))
                    {
                        return null;
                    }

                    return (semitones, velocity);
                }

                case 0:
                {
                    if (!int.TryParse(name, out var semitones))
                    {
                        return null;
                    }

                    return (semitones, 255);
                }

                default:
                    return null;
            }

        }

        private void buttonConvertNcwToWav_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName         = "cmd",
                WorkingDirectory = SrcDir,
                Arguments        = "/c ncw2wav"
            };

            var p = new Process();
            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();

            var success = p.ExitCode == 0;
            labelNcwToWavStatus.Text      = success ? STATE_SUCCESS : STATE_TOOL_ERROR;
            labelNcwToWavStatus.ForeColor = success ? ColorGreen : ColorRed;

            if (success)
            {
                foreach (var file in Directory.GetFiles(SrcDir))
                {
                    if (!file.EndsWith(".ncw"))
                    {
                        continue;
                    }

                    File.Delete(file);
                }
            }

            GetSrcDirType();
        }
        private void buttonSrcFileBrowse_Click(object sender, EventArgs e)
        {
            CommonFileDialog cfd = new CommonOpenFileDialog();
            if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxSrcFile.Text = cfd.FileName;
                ValidateSrcFile();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void buttonSrcDirBrowse_Click(object sender, EventArgs e)
        {
            CommonFileDialog cfd = new CommonOpenFileDialog { IsFolderPicker = true };
            if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxSrcDir.Text = cfd.FileName;
                ValidateSrcDir();
            }
        }
        private void textBoxSrcDir_TextChanged(object sender, EventArgs e)
        {
            ValidateSrcDir();
        }
        private void buttonDstDirBrowse_Click(object sender, EventArgs e)
        {
            CommonFileDialog cfd = new CommonOpenFileDialog { IsFolderPicker = true };
            if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBoxDstDir.Text = cfd.FileName;
                ValidateDstDir();
                ValidateRun();
            }
        }
        private void textBoxDstDir_TextChanged(object sender, EventArgs e)
        {
            ValidateDstDir();
            ValidateRun();
        }
        private void buttonExtract_Click(object sender, EventArgs e)
        {
            CommonFileDialog cfd = new CommonOpenFileDialog { IsFolderPicker = true };
            if (cfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var psi = new ProcessStartInfo
                {
                    FileName  = "cmd",
                    Arguments = $"/c nkidump -i \"{SrcFile}\" -o \"{cfd.FileName}\" -r -n",
                };

                var p = new Process();
                p.StartInfo = psi;
                p.Start();
                p.WaitForExit();

                var success = p.ExitCode == 0;
                labelExtractStatus.Text      = success ? STATE_SUCCESS : STATE_TOOL_ERROR;
                labelExtractStatus.ForeColor = success ? ColorGreen : ColorRed;

                if (success)
                {
                    textBoxSrcDir.Text = cfd.FileName;
                }

                ValidateSrcDir();

                MessageBox.Show($"NKI extraction {(success ? "successful" : "unsuccessful")}");
            }
        }
        private void textBoxPattern_TextChanged(object sender, EventArgs e)
        {
            ValidateRun();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            var list = new List<Tuple<string, Tuple<int, int>>>();

            var pattern = textBoxPattern.Text;
            foreach (var file in Directory.GetFiles(SrcDir))
            {
                if (Path.GetExtension(file) != ".wav")
                {
                    continue;
                }

                var semitone = 0;
                var velocity = 255;

                var fileName = Path.GetFileNameWithoutExtension(file);

                var i = 0;
                var p = 0;
                while (true)
                {
                    if ((i > fileName.Length - 1 && p < pattern.Length - 1) || (i < fileName.Length - 1 && p > pattern.Length - 1))
                    {
                        goto loopEnd;
                    }

                    if (i > fileName.Length - 1 && p > pattern.Length - 1)
                    {
                        break;
                    }

                    var fileChar    = fileName[i];
                    var patternChar = pattern[p];
                    if (patternChar == PATTERN_ESCAPE_SEQUENCE)
                    {
                        var nextChar = pattern[++p];
                        switch (nextChar)
                        {
                            case PATTERN_ESCAPE_NOTE:
                            {
                                p++;

                                var semitoneChar = char.ToLower(fileName[i++]);
                                if (semitoneChar < 'a' || semitoneChar > 'g')
                                {
                                    if (char.IsDigit(semitoneChar))
                                    {
                                        semitone += semitoneChar - '0';
                                        while (true)
                                        {
                                            if (i >= fileName.Length)
                                            {
                                                break;
                                            }

                                            semitoneChar = fileName[i++];
                                            if (!char.IsDigit(semitoneChar))
                                            {
                                                break;
                                            }

                                            semitone *= 10;
                                            semitone += semitoneChar - '0';
                                        }
                                        continue;
                                    }

                                    goto loopEnd;
                                }

                                var offsetTable = new[] { 7, 5, 4, 2, 0, 11, 9 };
                                semitone = offsetTable['g' - semitoneChar];
                                var accidental = fileName[i];
                                if (accidental == '#')
                                {
                                    semitone++;
                                    i++;
                                }
                                else if (accidental == 'b')
                                {
                                    semitone--;
                                    i++;
                                }

                                break;
                            }

                            case PATTERN_ESCAPE_OCTAVE:
                            {
                                p++;
                                var octaveChar = fileName[i++];

                                if (octaveChar < '0' || octaveChar > '9')
                                {
                                    goto loopEnd;
                                }

                                semitone += (octaveChar - '0') * 12;
                                break;
                            }

                            case PATTERN_ESCAPE_VELOCITY:
                            {
                                p++;
                                while (true)
                                {
                                    var c = fileName[i++];
                                    if (c < '0' || c > '9')
                                    {
                                        break;
                                    }

                                    velocity += c - '0';
                                    velocity *= 10;
                                }
                                break;
                            }
                        }
                    }
                    else if (patternChar == PATTERN_ANY_CHAR)
                    {
                        i++;
                        p++;
                    }
                    else
                    {
                        if (fileChar != patternChar)
                        {
                            goto loopEnd;
                        }

                        i++;
                        p++;
                    }
                }

                semitone += (int)numericUpDownScalePitch.Value;

                list.Add(new Tuple<string, Tuple<int, int>>(file, new Tuple<int, int>(semitone, velocity)));

                loopEnd:
                continue;
            }

            if (list.Count > 0)
            {
                var velocities = list.Select(p => p.Item2.Item2).ToArray();

                var max = velocities.Max();
                var min = velocities.Min();

                var scalar = 255.0F / (max - min);

                foreach (var (src, (semitone, velocityOg)) in list)
                {
                    var autoScale      = max - min == 0 && checkBoxAutoScaleVelocity.Checked;
                    var scaledVelocity = (int)((velocityOg - min) * scalar);

                    var velocity = autoScale ? scaledVelocity : velocityOg;

                    Console.WriteLine($"Extracting {src}");
                    File.Copy(src, Path.Combine(DstDir, $"{semitone}_{velocity}.wav"), true);
                }

                MessageBox.Show($"Extracted samples.");
            }
            else
            {
                MessageBox.Show($"No samples found.");
            }
        }
        private void buttonPitchShift_Click(object sender, EventArgs e)
        {
            var wavs = new List<(int, int)>();
            foreach (var wav in Directory.GetFiles(DstDir, "*.wav"))
            {
                var tuple = ParseWavFileName(wav);
                if (tuple.HasValue)
                {
                    wavs.Add(tuple.Value);
                }
            }

            for (var i = 24; i < 24 + 61; i++)
            {
                var closest = wavs.Select(p => p.Item1).OrderBy(p => Math.Abs(p - i)).First();
                if (closest == i)
                {
                    continue;
                }
                
                var delta   = closest - i;
                var mul     = Math.Pow(2, delta / 12.0);
                foreach (var velocity in wavs.FindAll(p => p.Item1 == closest).Select(p => p.Item2))
                {
                    if (InstrumentObj.Loop)
                    {
                        if (InstrumentObj.LoopInfo.TryGetValue(closest, out var val))
                        {
                            if (val.TryGetValue(velocity, out var loopVal))
                            {
                                var start    = (int)Math.Round(loopVal[0] * mul);
                                var duration = (int)Math.Round(loopVal[1] * mul);

                                if (!InstrumentObj.LoopInfo.ContainsKey(i))
                                {
                                    InstrumentObj.LoopInfo[i] = new Dictionary<int, int[]>();
                                }

                                InstrumentObj.LoopInfo[i][velocity] = new[] { start, duration };
                            }
                        }
                    }

                    var fileNew     = Path.Combine(DstDir, WavFileNameEncode(i,       velocity));
                    var fileNewTmp     = fileNew + ".tmp";
                    var fileClosest = Path.Combine(DstDir, WavFileNameEncode(closest, velocity));
                    
                    var waveIn  = new WaveFileReader(fileClosest);
                    var len        = waveIn.SampleCount;
                    var samples = new short[len];
                    for (int j = 0; j < len; j++)
                    {
                        samples[j] = (short)(waveIn.ReadNextSampleFrame()[0] * 32768);
                    }
                    waveIn.Close();
                    
                    var newLen     = (int)Math.Round(len * mul);
                    var newSamples = new short[newLen];

                    var step = (1 / mul) * ((len - 1) / (double)len);
                    var t    = 0.0;
                    for (var j = 0; j < newLen; j++)
                    {
                        var tFloor = (int)t;
                        var tCeil  = tFloor + 1;
                        var tRem   = t - tFloor;

                        if (tRem > 0.99999)
                        {
                            tFloor++;
                            tCeil++;
                            tRem = 0;
                        }

                        var a     = samples[tFloor];
                        var b     = samples[tCeil];
                        var value = a + (b - a) * tRem;

                        newSamples[j] = (short)Math.Min(short.MaxValue, Math.Max(short.MinValue, value));

                        t += step;
                    }

                    using var waveOut = new WaveFileWriter(fileNewTmp, new WaveFormat(48000, 16, 1));
                    waveOut.WriteSamples(newSamples, 0, newSamples.Length);
                    waveOut.Close();

                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo
                    {
                        FileName  = "ffmpeg.exe",
                        Arguments = $"-i \"{fileNewTmp}\" -fflags +bitexact -flags:v +bitexact -flags:a +bitexact -ac 1 -ar 48000 -c:a pcm_s16le \"{fileNew}\""
                    };
                    p.Start();
                    p.WaitForExit();
                    
                    File.Delete(fileNewTmp);
                }
            }

            var success = true;
            labelExtractStatus.Text      = success ? STATE_SUCCESS : STATE_TOOL_ERROR;
            labelExtractStatus.ForeColor = success ? ColorGreen : ColorRed;

            UpdateLoopDomains();
            GenerateInstrumentGui();

            MessageBox.Show($"Pitch shifting {(success ? "successful" : "unsuccessful")}.");
        }
        public int GetSampleLength(int pSemitones, int pVelocity)
        {
            using (var file = File.OpenRead(Path.Combine(DstDir, WavFileNameEncode(pSemitones, pVelocity))))
            {
                var reader = new BinaryReader(file);
                reader.BaseStream.Seek(40, SeekOrigin.Begin);
                return (int)(reader.ReadUInt32() / 2);
            }
        }
        public void LoopAllUntilEnd()
        {
            var files = Directory.GetFiles(DstDir, "*.wav");

            foreach (var wav in files)
            {
                var tuple = ParseWavFileName(wav);
                if (!tuple.HasValue)
                {
                    continue;
                }

                var (semitones, velocity) = tuple.Value;
                if (!InstrumentObj.LoopInfo.ContainsKey(semitones))
                {
                    InstrumentObj.LoopInfo[semitones] = new Dictionary<int, int[]>();
                }

                if (!InstrumentObj.LoopInfo[semitones].ContainsKey(velocity))
                {
                    InstrumentObj.LoopInfo[semitones][velocity] = new[]
                    {
                        0, GetSampleLength(semitones, velocity)
                    };
                }

                SetUpLoopNoteDomainUpDown();
                UpdateLoopTable();
            }
        }

        public int GetCurrentVelocity()
        {
            return (int)domainUpDownVelocity.SelectedItem;
        }

        public void UpdateLoopTable()
        {
            var entry = InstrumentObj.LoopInfo[GetCurrentNote()][GetCurrentVelocity()];

            if (!textBoxLoopStartSeconds.Focused)
            {
                textBoxLoopStartSeconds.Text = $"{entry[0] / 48000.0F:0.0000}";
            }

            if (!textBoxLoopStartSamples.Focused)
            {
                textBoxLoopStartSamples.Text = $"{entry[0]}";
            }

            if (!textBoxLoopDurationSeconds.Focused)
            {
                textBoxLoopDurationSeconds.Text = $"{entry[1] / 48000.0F:0.0000}";
            }

            if (!textBoxLoopDurationSamples.Focused)
            {
                textBoxLoopDurationSamples.Text = $"{entry[1]}";
            }
        }

        private void checkBoxLoop_CheckedChanged(object sender, EventArgs e)
        {
            var loop = checkBoxLoop.Checked;

            groupBoxLoop.Enabled = loop;
            InstrumentObj.Loop   = loop;

            if (loop)
            {
                if (InstrumentObj.LoopInfo.Keys.Count == 0)
                {
                    var files = Directory.GetFiles(DstDir, "*.wav");
                    if (files.Length == 0)
                    {
                        LoopAllUntilEnd();
                    }
                    else
                    {
                        foreach (var file in files)
                        {
                            var tuple = ParseWavFileName(file);
                            if (!tuple.HasValue)
                            {
                                continue;
                            }

                            var (semitones, velocity) = tuple.Value;
                            if (!InstrumentObj.LoopInfo.ContainsKey(semitones))
                            {
                                InstrumentObj.LoopInfo[semitones] = new Dictionary<int, int[]>();
                            }

                            if (!InstrumentObj.LoopInfo[semitones].ContainsKey(velocity))
                            {
                                InstrumentObj.LoopInfo[semitones][velocity] = new[]
                                {
                                    0, GetSampleLength(semitones, velocity)
                                };
                            }
                        }
                    }
                }

                SetUpLoopNoteDomainUpDown();
                UpdateNoteVelocities();
            }
        }

        private void SetUpLoopNoteDomainUpDown()
        {
            domainUpDownLoopNote.Items.Clear();

            var table = new[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            foreach (var i in InstrumentObj.LoopInfo.Keys.ToList().OrderByDescending(p => p))
            {
                domainUpDownLoopNote.Items.Add($"{table[i % 12]}{i / 12}");
            }

            domainUpDownLoopNote.SelectedIndex = 0;
        }

        private void buttonTranspose_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(SrcDir, "*.wav");

            var i = 0;
            foreach (var wav in files)
            {
                var tuple = ParseWavFileName(wav);
                if (!tuple.HasValue)
                {
                    continue;
                }

                var (semitones, velocity) =  tuple.Value;
                semitones                 += (int)numericUpDownTranspose.Value;

                File.Move(wav, Path.Combine(SrcDir, WavFileNameEncode(semitones, velocity)));

                i++;
            }

            MessageBox.Show($"{i} / {files.Length} wav files transposed.");
        }

        private void buttonConfigSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            InstrumentObj.Name       = textBoxInstrumentName.Text;
            InstrumentObj.SoundType  = checkBoxLoop.Checked ? "attack loop" : "attack";
            InstrumentObj.FadeForced = (float)numericUpDownFade.Value;

            if (InstrumentObj.LoopInfo == null)
            {
                MessageBox.Show("Could not save - invalid loop information");
                return;
            }

            InstrumentObj.SaveЈson();
            MessageBox.Show("Saved.");
        }

        private void textBoxInstrumentName_TextChanged(object sender, EventArgs e)
        {
        }

        public int GetCurrentNote()
        {
            var offsetTable = new[] { 7, 5, 4, 2, 0, 11, 9 };

            var item = (string)domainUpDownLoopNote.SelectedItem;
            var key  = offsetTable['G' - item[0]];
            if (item.Contains('#'))
            {
                key++;
            }

            key += (item.Last() - '0') * 12;
            return key;
        }

        public void UpdateNoteVelocities()
        {
            domainUpDownVelocity.Items.Clear();
            domainUpDownVelocity.Items.AddRange(InstrumentObj.LoopInfo[GetCurrentNote()].Keys);

            domainUpDownVelocity.SelectedIndex = 0;
        }

        private void domainUpDownVelocity_SelectedItemChanged(object sender, EventArgs e)
        {
            UpdateLoopDomains();
        }

        private void domainUpDownLoopNote_SelectedItemChanged(object sender, EventArgs e)
        {
            UpdateLoopDomains();
        }

        private void UpdateLoopDomains()
        {
            UpdateNoteVelocities();
            UpdateLoopTable();
        }

        private void textBoxLoopDurationSamples_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDownVelocity.Focused || domainUpDownLoopNote.Focused || textBoxLoopDurationSeconds.Focused)
            {
                return;
            }

            int.TryParse(textBoxLoopDurationSamples.Text, out InstrumentObj.LoopInfo[GetCurrentNote()][GetCurrentVelocity()][1]);
            UpdateLoopDomains();
        }

        private void textBoxLoopDurationSeconds_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDownVelocity.Focused || domainUpDownLoopNote.Focused || textBoxLoopDurationSamples.Focused)
            {
                return;
            }

            if (float.TryParse(textBoxLoopDurationSeconds.Text, out var seconds))
            {
                InstrumentObj.LoopInfo[GetCurrentNote()][GetCurrentVelocity()][1] = (int)(seconds * 48000);
            }
            UpdateLoopDomains();
        }

        private void textBoxLoopStartSeconds_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDownVelocity.Focused || domainUpDownLoopNote.Focused || textBoxLoopStartSamples.Focused)
            {
                return;
            }

            if (float.TryParse(textBoxLoopStartSeconds.Text, out var seconds))
            {
                InstrumentObj.LoopInfo[GetCurrentNote()][GetCurrentVelocity()][0] = (int)(seconds * 48000);
            }
            UpdateLoopDomains();
        }

        private void textBoxLoopStartSamples_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDownVelocity.Focused || domainUpDownLoopNote.Focused || textBoxLoopStartSeconds.Focused)
            {
                return;
            }

            int.TryParse(textBoxLoopStartSamples.Text, out InstrumentObj.LoopInfo[GetCurrentNote()][GetCurrentVelocity()][0]);
            UpdateLoopDomains();

            buttonCopyLoop.Enabled = true;
        }

        private void buttonLoopAllUntilEnd_Click(object sender, EventArgs e)
        {
            LoopAllUntilEnd();
            UpdateLoopDomains();
        }

        private void buttonCopyLoop_Click(object sender, EventArgs e)
        {
            var data  = InstrumentObj.LoopInfo[GetCurrentNote()][GetCurrentVelocity()];
            var start = data[0];
            var end   = data[1];

            foreach (var semi in InstrumentObj.LoopInfo.Keys.ToArray())
            {
                foreach (var pair in InstrumentObj.LoopInfo[semi].ToArray())
                {
                    var velocity = pair.Key;
                    var len      = GetSampleLength(semi, velocity) - 1;
                    InstrumentObj.LoopInfo[semi][velocity] = new[] { Math.Min(start, len), Math.Min(end, len) };
                }
            }
        }
    }
}