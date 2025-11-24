namespace smanip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSrcDirBrowse         = new System.Windows.Forms.Button();
            this.label2                     = new System.Windows.Forms.Label();
            this.textBoxSrcDir              = new System.Windows.Forms.TextBox();
            this.groupBoxSrcDir             = new System.Windows.Forms.GroupBox();
            this.labelFormat                = new System.Windows.Forms.Label();
            this.labelNcwToWavStatus        = new System.Windows.Forms.Label();
            this.groupBoxWav                = new System.Windows.Forms.GroupBox();
            this.groupBoxScaling            = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoScaleVelocity  = new System.Windows.Forms.CheckBox();
            this.label9                     = new System.Windows.Forms.Label();
            this.numericUpDownScalePitch    = new System.Windows.Forms.NumericUpDown();
            this.label8                     = new System.Windows.Forms.Label();
            this.labelDstDirValid           = new System.Windows.Forms.Label();
            this.buttonDstDirBrowse         = new System.Windows.Forms.Button();
            this.textBoxDstDir              = new System.Windows.Forms.TextBox();
            this.label5                     = new System.Windows.Forms.Label();
            this.buttonRun                  = new System.Windows.Forms.Button();
            this.textBoxPattern             = new System.Windows.Forms.TextBox();
            this.label4                     = new System.Windows.Forms.Label();
            this.buttonConvertNcwToWav      = new System.Windows.Forms.Button();
            this.labelSrcType               = new System.Windows.Forms.Label();
            this.label1                     = new System.Windows.Forms.Label();
            this.labelSrcDirValid           = new System.Windows.Forms.Label();
            this.groupBoxDir                = new System.Windows.Forms.GroupBox();
            this.groupBoxFile               = new System.Windows.Forms.GroupBox();
            this.labelExtractStatus         = new System.Windows.Forms.Label();
            this.buttonExtract              = new System.Windows.Forms.Button();
            this.label3                     = new System.Windows.Forms.Label();
            this.labelSrcFileValid          = new System.Windows.Forms.Label();
            this.textBoxSrcFile             = new System.Windows.Forms.TextBox();
            this.buttonSrcFileBrowse        = new System.Windows.Forms.Button();
            this.groupBoxInstrument         = new System.Windows.Forms.GroupBox();
            this.numericUpDownFade          = new System.Windows.Forms.NumericUpDown();
            this.label15                    = new System.Windows.Forms.Label();
            this.buttonTranspose            = new System.Windows.Forms.Button();
            this.numericUpDownTranspose     = new System.Windows.Forms.NumericUpDown();
            this.buttonConfigSave           = new System.Windows.Forms.Button();
            this.labelNoteStatus            = new System.Windows.Forms.Label();
            this.buttonPitchShift           = new System.Windows.Forms.Button();
            this.groupBoxLoop               = new System.Windows.Forms.GroupBox();
            this.label14                    = new System.Windows.Forms.Label();
            this.domainUpDownVelocity       = new System.Windows.Forms.DomainUpDown();
            this.buttonLoopAllUntilEnd      = new System.Windows.Forms.Button();
            this.groupBox1                  = new System.Windows.Forms.GroupBox();
            this.buttonCopyLoop             = new System.Windows.Forms.Button();
            this.groupBoxLoopDuration       = new System.Windows.Forms.GroupBox();
            this.textBoxLoopDurationSeconds = new System.Windows.Forms.TextBox();
            this.textBoxLoopDurationSamples = new System.Windows.Forms.TextBox();
            this.groupBoxLoopStart          = new System.Windows.Forms.GroupBox();
            this.textBoxLoopStartSeconds    = new System.Windows.Forms.TextBox();
            this.textBoxLoopStartSamples    = new System.Windows.Forms.TextBox();
            this.label13                    = new System.Windows.Forms.Label();
            this.label12                    = new System.Windows.Forms.Label();
            this.label11                    = new System.Windows.Forms.Label();
            this.label10                    = new System.Windows.Forms.Label();
            this.label7                     = new System.Windows.Forms.Label();
            this.domainUpDownLoopNote       = new System.Windows.Forms.DomainUpDown();
            this.label6                     = new System.Windows.Forms.Label();
            this.textBoxInstrumentName      = new System.Windows.Forms.TextBox();
            this.checkBoxLoop               = new System.Windows.Forms.CheckBox();
            this.groupBoxSrcDir.SuspendLayout();
            this.groupBoxWav.SuspendLayout();
            this.groupBoxScaling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalePitch)).BeginInit();
            this.groupBoxDir.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxInstrument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranspose)).BeginInit();
            this.groupBoxLoop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxLoopDuration.SuspendLayout();
            this.groupBoxLoopStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSrcDirBrowse
            // 
            this.buttonSrcDirBrowse.Location                =  new System.Drawing.Point(112, 44);
            this.buttonSrcDirBrowse.Name                    =  "buttonSrcDirBrowse";
            this.buttonSrcDirBrowse.Size                    =  new System.Drawing.Size(79, 23);
            this.buttonSrcDirBrowse.TabIndex                =  1;
            this.buttonSrcDirBrowse.Text                    =  "Browse";
            this.buttonSrcDirBrowse.UseVisualStyleBackColor =  true;
            this.buttonSrcDirBrowse.Click                   += new System.EventHandler(this.buttonSrcDirBrowse_Click);
            // 
            // label2
            // 
            this.label2.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location  = new System.Drawing.Point(6, 16);
            this.label2.Name      = "label2";
            this.label2.Size      = new System.Drawing.Size(100, 23);
            this.label2.TabIndex  = 2;
            this.label2.Text      = "Selected folder:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSrcDir
            // 
            this.textBoxSrcDir.Location    =  new System.Drawing.Point(112, 18);
            this.textBoxSrcDir.Name        =  "textBoxSrcDir";
            this.textBoxSrcDir.Size        =  new System.Drawing.Size(593, 20);
            this.textBoxSrcDir.TabIndex    =  3;
            this.textBoxSrcDir.TextChanged += new System.EventHandler(this.textBoxSrcDir_TextChanged);
            // 
            // groupBoxSrcDir
            // 
            this.groupBoxSrcDir.Controls.Add(this.labelFormat);
            this.groupBoxSrcDir.Controls.Add(this.labelNcwToWavStatus);
            this.groupBoxSrcDir.Controls.Add(this.groupBoxWav);
            this.groupBoxSrcDir.Controls.Add(this.buttonConvertNcwToWav);
            this.groupBoxSrcDir.Controls.Add(this.labelSrcType);
            this.groupBoxSrcDir.Controls.Add(this.label1);
            this.groupBoxSrcDir.Enabled  = false;
            this.groupBoxSrcDir.Location = new System.Drawing.Point(6, 73);
            this.groupBoxSrcDir.Name     = "groupBoxSrcDir";
            this.groupBoxSrcDir.Size     = new System.Drawing.Size(699, 392);
            this.groupBoxSrcDir.TabIndex = 4;
            this.groupBoxSrcDir.TabStop  = false;
            // 
            // labelFormat
            // 
            this.labelFormat.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormat.Location  = new System.Drawing.Point(6, 76);
            this.labelFormat.Name      = "labelFormat";
            this.labelFormat.Size      = new System.Drawing.Size(432, 23);
            this.labelFormat.TabIndex  = 14;
            this.labelFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNcwToWavStatus
            // 
            this.labelNcwToWavStatus.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNcwToWavStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNcwToWavStatus.Location  = new System.Drawing.Point(6, 42);
            this.labelNcwToWavStatus.Name      = "labelNcwToWavStatus";
            this.labelNcwToWavStatus.Size      = new System.Drawing.Size(100, 23);
            this.labelNcwToWavStatus.TabIndex  = 13;
            this.labelNcwToWavStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxWav
            // 
            this.groupBoxWav.Controls.Add(this.groupBoxScaling);
            this.groupBoxWav.Controls.Add(this.label8);
            this.groupBoxWav.Controls.Add(this.labelDstDirValid);
            this.groupBoxWav.Controls.Add(this.buttonDstDirBrowse);
            this.groupBoxWav.Controls.Add(this.textBoxDstDir);
            this.groupBoxWav.Controls.Add(this.label5);
            this.groupBoxWav.Controls.Add(this.buttonRun);
            this.groupBoxWav.Controls.Add(this.textBoxPattern);
            this.groupBoxWav.Controls.Add(this.label4);
            this.groupBoxWav.Enabled  = false;
            this.groupBoxWav.Location = new System.Drawing.Point(6, 102);
            this.groupBoxWav.Name     = "groupBoxWav";
            this.groupBoxWav.Size     = new System.Drawing.Size(687, 284);
            this.groupBoxWav.TabIndex = 3;
            this.groupBoxWav.TabStop  = false;
            // 
            // groupBoxScaling
            // 
            this.groupBoxScaling.Controls.Add(this.checkBoxAutoScaleVelocity);
            this.groupBoxScaling.Controls.Add(this.label9);
            this.groupBoxScaling.Controls.Add(this.numericUpDownScalePitch);
            this.groupBoxScaling.Location = new System.Drawing.Point(6, 93);
            this.groupBoxScaling.Name     = "groupBoxScaling";
            this.groupBoxScaling.Size     = new System.Drawing.Size(675, 71);
            this.groupBoxScaling.TabIndex = 12;
            this.groupBoxScaling.TabStop  = false;
            // 
            // checkBoxAutoScaleVelocity
            // 
            this.checkBoxAutoScaleVelocity.Location                = new System.Drawing.Point(6, 16);
            this.checkBoxAutoScaleVelocity.Name                    = "checkBoxAutoScaleVelocity";
            this.checkBoxAutoScaleVelocity.Size                    = new System.Drawing.Size(115, 24);
            this.checkBoxAutoScaleVelocity.TabIndex                = 12;
            this.checkBoxAutoScaleVelocity.Text                    = "Auto scale velocity";
            this.checkBoxAutoScaleVelocity.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location  = new System.Drawing.Point(139, 16);
            this.label9.Name      = "label9";
            this.label9.Size      = new System.Drawing.Size(125, 23);
            this.label9.TabIndex  = 10;
            this.label9.Text      = "Scale pitch:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownScalePitch
            // 
            this.numericUpDownScalePitch.Location = new System.Drawing.Point(139, 45);
            this.numericUpDownScalePitch.Name     = "numericUpDownScalePitch";
            this.numericUpDownScalePitch.Size     = new System.Drawing.Size(36, 20);
            this.numericUpDownScalePitch.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location  = new System.Drawing.Point(6, 39);
            this.label8.Name      = "label8";
            this.label8.Size      = new System.Drawing.Size(94, 64);
            this.label8.TabIndex  = 7;
            this.label8.Text      = "%n - note name\r\n%o - octave\r\n%v - velocity\r\n* - any character";
            // 
            // labelDstDirValid
            // 
            this.labelDstDirValid.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDstDirValid.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelDstDirValid.Location  = new System.Drawing.Point(6, 205);
            this.labelDstDirValid.Name      = "labelDstDirValid";
            this.labelDstDirValid.Size      = new System.Drawing.Size(88, 23);
            this.labelDstDirValid.TabIndex  = 6;
            this.labelDstDirValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDstDirBrowse
            // 
            this.buttonDstDirBrowse.Location                =  new System.Drawing.Point(100, 205);
            this.buttonDstDirBrowse.Name                    =  "buttonDstDirBrowse";
            this.buttonDstDirBrowse.Size                    =  new System.Drawing.Size(79, 23);
            this.buttonDstDirBrowse.TabIndex                =  5;
            this.buttonDstDirBrowse.Text                    =  "Browse";
            this.buttonDstDirBrowse.UseVisualStyleBackColor =  true;
            this.buttonDstDirBrowse.Click                   += new System.EventHandler(this.buttonDstDirBrowse_Click);
            // 
            // textBoxDstDir
            // 
            this.textBoxDstDir.Location    =  new System.Drawing.Point(100, 181);
            this.textBoxDstDir.Name        =  "textBoxDstDir";
            this.textBoxDstDir.Size        =  new System.Drawing.Size(581, 20);
            this.textBoxDstDir.TabIndex    =  5;
            this.textBoxDstDir.TextChanged += new System.EventHandler(this.textBoxDstDir_TextChanged);
            // 
            // label5
            // 
            this.label5.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location  = new System.Drawing.Point(6, 179);
            this.label5.Name      = "label5";
            this.label5.Size      = new System.Drawing.Size(88, 23);
            this.label5.TabIndex  = 3;
            this.label5.Text      = "Destination:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRun
            // 
            this.buttonRun.Enabled                 =  false;
            this.buttonRun.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location                =  new System.Drawing.Point(6, 255);
            this.buttonRun.Name                    =  "buttonRun";
            this.buttonRun.Size                    =  new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex                =  2;
            this.buttonRun.Text                    =  "Run";
            this.buttonRun.UseVisualStyleBackColor =  true;
            this.buttonRun.Click                   += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location    =  new System.Drawing.Point(100, 18);
            this.textBoxPattern.Name        =  "textBoxPattern";
            this.textBoxPattern.Size        =  new System.Drawing.Size(581, 20);
            this.textBoxPattern.TabIndex    =  1;
            this.textBoxPattern.TextChanged += new System.EventHandler(this.textBoxPattern_TextChanged);
            // 
            // label4
            // 
            this.label4.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location  = new System.Drawing.Point(6, 16);
            this.label4.Name      = "label4";
            this.label4.Size      = new System.Drawing.Size(88, 23);
            this.label4.TabIndex  = 0;
            this.label4.Text      = "Pattern:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonConvertNcwToWav
            // 
            this.buttonConvertNcwToWav.Enabled                 =  false;
            this.buttonConvertNcwToWav.Location                =  new System.Drawing.Point(106, 42);
            this.buttonConvertNcwToWav.Name                    =  "buttonConvertNcwToWav";
            this.buttonConvertNcwToWav.Size                    =  new System.Drawing.Size(179, 23);
            this.buttonConvertNcwToWav.TabIndex                =  2;
            this.buttonConvertNcwToWav.Text                    =  "Convert NCW to WAV";
            this.buttonConvertNcwToWav.UseVisualStyleBackColor =  true;
            this.buttonConvertNcwToWav.Click                   += new System.EventHandler(this.buttonConvertNcwToWav_Click);
            // 
            // labelSrcType
            // 
            this.labelSrcType.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelSrcType.Location  = new System.Drawing.Point(106, 16);
            this.labelSrcType.Name      = "labelSrcType";
            this.labelSrcType.Size      = new System.Drawing.Size(179, 23);
            this.labelSrcType.TabIndex  = 1;
            this.labelSrcType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location  = new System.Drawing.Point(6, 16);
            this.label1.Name      = "label1";
            this.label1.Size      = new System.Drawing.Size(109, 23);
            this.label1.TabIndex  = 0;
            this.label1.Text      = "Folder type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSrcDirValid
            // 
            this.labelSrcDirValid.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcDirValid.ForeColor = System.Drawing.Color.DarkRed;
            this.labelSrcDirValid.Location  = new System.Drawing.Point(6, 44);
            this.labelSrcDirValid.Name      = "labelSrcDirValid";
            this.labelSrcDirValid.Size      = new System.Drawing.Size(88, 23);
            this.labelSrcDirValid.TabIndex  = 7;
            this.labelSrcDirValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxDir
            // 
            this.groupBoxDir.Controls.Add(this.label2);
            this.groupBoxDir.Controls.Add(this.labelSrcDirValid);
            this.groupBoxDir.Controls.Add(this.buttonSrcDirBrowse);
            this.groupBoxDir.Controls.Add(this.groupBoxSrcDir);
            this.groupBoxDir.Controls.Add(this.textBoxSrcDir);
            this.groupBoxDir.Location = new System.Drawing.Point(12, 201);
            this.groupBoxDir.Name     = "groupBoxDir";
            this.groupBoxDir.Size     = new System.Drawing.Size(711, 471);
            this.groupBoxDir.TabIndex = 8;
            this.groupBoxDir.TabStop  = false;
            this.groupBoxDir.Text     = "Folder";
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.labelExtractStatus);
            this.groupBoxFile.Controls.Add(this.buttonExtract);
            this.groupBoxFile.Controls.Add(this.label3);
            this.groupBoxFile.Controls.Add(this.labelSrcFileValid);
            this.groupBoxFile.Controls.Add(this.textBoxSrcFile);
            this.groupBoxFile.Controls.Add(this.buttonSrcFileBrowse);
            this.groupBoxFile.Font     = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFile.Name     = "groupBoxFile";
            this.groupBoxFile.Size     = new System.Drawing.Size(711, 150);
            this.groupBoxFile.TabIndex = 9;
            this.groupBoxFile.TabStop  = false;
            this.groupBoxFile.Text     = "NKI";
            // 
            // labelExtractStatus
            // 
            this.labelExtractStatus.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtractStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.labelExtractStatus.Location  = new System.Drawing.Point(6, 123);
            this.labelExtractStatus.Name      = "labelExtractStatus";
            this.labelExtractStatus.Size      = new System.Drawing.Size(306, 23);
            this.labelExtractStatus.TabIndex  = 8;
            this.labelExtractStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonExtract
            // 
            this.buttonExtract.Enabled                 =  false;
            this.buttonExtract.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtract.Location                =  new System.Drawing.Point(6, 97);
            this.buttonExtract.Name                    =  "buttonExtract";
            this.buttonExtract.Size                    =  new System.Drawing.Size(79, 23);
            this.buttonExtract.TabIndex                =  12;
            this.buttonExtract.Text                    =  "Extract";
            this.buttonExtract.UseVisualStyleBackColor =  true;
            this.buttonExtract.Click                   += new System.EventHandler(this.buttonExtract_Click);
            // 
            // label3
            // 
            this.label3.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location  = new System.Drawing.Point(6, 16);
            this.label3.Name      = "label3";
            this.label3.Size      = new System.Drawing.Size(100, 23);
            this.label3.TabIndex  = 9;
            this.label3.Text      = "Selected file:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSrcFileValid
            // 
            this.labelSrcFileValid.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcFileValid.ForeColor = System.Drawing.Color.DarkRed;
            this.labelSrcFileValid.Location  = new System.Drawing.Point(6, 44);
            this.labelSrcFileValid.Name      = "labelSrcFileValid";
            this.labelSrcFileValid.Size      = new System.Drawing.Size(88, 23);
            this.labelSrcFileValid.TabIndex  = 11;
            this.labelSrcFileValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSrcFile
            // 
            this.textBoxSrcFile.Location = new System.Drawing.Point(112, 18);
            this.textBoxSrcFile.Name     = "textBoxSrcFile";
            this.textBoxSrcFile.Size     = new System.Drawing.Size(593, 20);
            this.textBoxSrcFile.TabIndex = 10;
            // 
            // buttonSrcFileBrowse
            // 
            this.buttonSrcFileBrowse.Location                =  new System.Drawing.Point(112, 44);
            this.buttonSrcFileBrowse.Name                    =  "buttonSrcFileBrowse";
            this.buttonSrcFileBrowse.Size                    =  new System.Drawing.Size(79, 23);
            this.buttonSrcFileBrowse.TabIndex                =  0;
            this.buttonSrcFileBrowse.Text                    =  "Browse";
            this.buttonSrcFileBrowse.UseVisualStyleBackColor =  true;
            this.buttonSrcFileBrowse.Click                   += new System.EventHandler(this.buttonSrcFileBrowse_Click);
            // 
            // groupBoxInstrument
            // 
            this.groupBoxInstrument.Controls.Add(this.numericUpDownFade);
            this.groupBoxInstrument.Controls.Add(this.label15);
            this.groupBoxInstrument.Controls.Add(this.buttonTranspose);
            this.groupBoxInstrument.Controls.Add(this.numericUpDownTranspose);
            this.groupBoxInstrument.Controls.Add(this.buttonConfigSave);
            this.groupBoxInstrument.Controls.Add(this.labelNoteStatus);
            this.groupBoxInstrument.Controls.Add(this.buttonPitchShift);
            this.groupBoxInstrument.Controls.Add(this.groupBoxLoop);
            this.groupBoxInstrument.Controls.Add(this.label6);
            this.groupBoxInstrument.Controls.Add(this.textBoxInstrumentName);
            this.groupBoxInstrument.Controls.Add(this.checkBoxLoop);
            this.groupBoxInstrument.Enabled  = false;
            this.groupBoxInstrument.Location = new System.Drawing.Point(784, 12);
            this.groupBoxInstrument.Name     = "groupBoxInstrument";
            this.groupBoxInstrument.Size     = new System.Drawing.Size(625, 660);
            this.groupBoxInstrument.TabIndex = 13;
            this.groupBoxInstrument.TabStop  = false;
            this.groupBoxInstrument.Text     = "Instrument config";
            // 
            // numericUpDownFade
            // 
            this.numericUpDownFade.DecimalPlaces = 2;
            this.numericUpDownFade.Increment = new decimal(new int[]
            {
                1, 0, 0, 131072
            });
            this.numericUpDownFade.Location = new System.Drawing.Point(257, 53);
            this.numericUpDownFade.Minimum = new decimal(new int[]
            {
                1, 0, 0, 131072
            });
            this.numericUpDownFade.Name     = "numericUpDownFade";
            this.numericUpDownFade.Size     = new System.Drawing.Size(56, 20);
            this.numericUpDownFade.TabIndex = 13;
            this.numericUpDownFade.Value = new decimal(new int[]
            {
                1, 0, 0, 131072
            });
            // 
            // label15
            // 
            this.label15.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location  = new System.Drawing.Point(6, 50);
            this.label15.Name      = "label15";
            this.label15.Size      = new System.Drawing.Size(104, 23);
            this.label15.TabIndex  = 19;
            this.label15.Text      = "Forced fade:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonTranspose
            // 
            this.buttonTranspose.Location                =  new System.Drawing.Point(6, 93);
            this.buttonTranspose.Name                    =  "buttonTranspose";
            this.buttonTranspose.Size                    =  new System.Drawing.Size(162, 23);
            this.buttonTranspose.TabIndex                =  17;
            this.buttonTranspose.Text                    =  "Transpose all by:";
            this.buttonTranspose.UseVisualStyleBackColor =  true;
            this.buttonTranspose.Click                   += new System.EventHandler(this.buttonTranspose_Click);
            // 
            // numericUpDownTranspose
            // 
            this.numericUpDownTranspose.Location = new System.Drawing.Point(257, 96);
            this.numericUpDownTranspose.Minimum = new decimal(new int[]
            {
                100, 0, 0, -2147483648
            });
            this.numericUpDownTranspose.Name     = "numericUpDownTranspose";
            this.numericUpDownTranspose.Size     = new System.Drawing.Size(56, 20);
            this.numericUpDownTranspose.TabIndex = 13;
            // 
            // buttonConfigSave
            // 
            this.buttonConfigSave.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigSave.Location                =  new System.Drawing.Point(12, 619);
            this.buttonConfigSave.Name                    =  "buttonConfigSave";
            this.buttonConfigSave.Size                    =  new System.Drawing.Size(75, 23);
            this.buttonConfigSave.TabIndex                =  13;
            this.buttonConfigSave.Text                    =  "Save";
            this.buttonConfigSave.UseVisualStyleBackColor =  true;
            this.buttonConfigSave.Click                   += new System.EventHandler(this.buttonConfigSave_Click);
            // 
            // labelNoteStatus
            // 
            this.labelNoteStatus.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoteStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.labelNoteStatus.Location  = new System.Drawing.Point(257, 122);
            this.labelNoteStatus.Name      = "labelNoteStatus";
            this.labelNoteStatus.Size      = new System.Drawing.Size(104, 23);
            this.labelNoteStatus.TabIndex  = 15;
            this.labelNoteStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPitchShift
            // 
            this.buttonPitchShift.Location                =  new System.Drawing.Point(6, 122);
            this.buttonPitchShift.Name                    =  "buttonPitchShift";
            this.buttonPitchShift.Size                    =  new System.Drawing.Size(162, 23);
            this.buttonPitchShift.TabIndex                =  8;
            this.buttonPitchShift.Text                    =  "Fill gaps by pitch shifting";
            this.buttonPitchShift.UseVisualStyleBackColor =  true;
            this.buttonPitchShift.Click                   += new System.EventHandler(this.buttonPitchShift_Click);
            // 
            // groupBoxLoop
            // 
            this.groupBoxLoop.Controls.Add(this.label14);
            this.groupBoxLoop.Controls.Add(this.domainUpDownVelocity);
            this.groupBoxLoop.Controls.Add(this.buttonLoopAllUntilEnd);
            this.groupBoxLoop.Controls.Add(this.groupBox1);
            this.groupBoxLoop.Controls.Add(this.label7);
            this.groupBoxLoop.Controls.Add(this.domainUpDownLoopNote);
            this.groupBoxLoop.Enabled  = false;
            this.groupBoxLoop.Location = new System.Drawing.Point(6, 189);
            this.groupBoxLoop.Name     = "groupBoxLoop";
            this.groupBoxLoop.Size     = new System.Drawing.Size(613, 424);
            this.groupBoxLoop.TabIndex = 16;
            this.groupBoxLoop.TabStop  = false;
            this.groupBoxLoop.Text     = "Loop information";
            // 
            // label14
            // 
            this.label14.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location  = new System.Drawing.Point(168, 149);
            this.label14.Name      = "label14";
            this.label14.Size      = new System.Drawing.Size(77, 23);
            this.label14.TabIndex  = 19;
            this.label14.Text      = "With velocity:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // domainUpDownVelocity
            // 
            this.domainUpDownVelocity.Items.Add("C");
            this.domainUpDownVelocity.Items.Add("D");
            this.domainUpDownVelocity.Items.Add("E");
            this.domainUpDownVelocity.Items.Add("F");
            this.domainUpDownVelocity.Items.Add("G");
            this.domainUpDownVelocity.Location            =  new System.Drawing.Point(251, 152);
            this.domainUpDownVelocity.Name                =  "domainUpDownVelocity";
            this.domainUpDownVelocity.Size                =  new System.Drawing.Size(50, 20);
            this.domainUpDownVelocity.TabIndex            =  18;
            this.domainUpDownVelocity.SelectedItemChanged += new System.EventHandler(this.domainUpDownVelocity_SelectedItemChanged);
            // 
            // buttonLoopAllUntilEnd
            // 
            this.buttonLoopAllUntilEnd.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoopAllUntilEnd.Location                =  new System.Drawing.Point(6, 115);
            this.buttonLoopAllUntilEnd.Name                    =  "buttonLoopAllUntilEnd";
            this.buttonLoopAllUntilEnd.Size                    =  new System.Drawing.Size(98, 23);
            this.buttonLoopAllUntilEnd.TabIndex                =  17;
            this.buttonLoopAllUntilEnd.Text                    =  "Loop all until end";
            this.buttonLoopAllUntilEnd.UseVisualStyleBackColor =  true;
            this.buttonLoopAllUntilEnd.Click                   += new System.EventHandler(this.buttonLoopAllUntilEnd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCopyLoop);
            this.groupBox1.Controls.Add(this.groupBoxLoopDuration);
            this.groupBox1.Controls.Add(this.groupBoxLoopStart);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(6, 175);
            this.groupBox1.Name     = "groupBox1";
            this.groupBox1.Size     = new System.Drawing.Size(601, 243);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop  = false;
            // 
            // buttonCopyLoop
            // 
            this.buttonCopyLoop.Font                    =  new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyLoop.Location                =  new System.Drawing.Point(6, 150);
            this.buttonCopyLoop.Name                    =  "buttonCopyLoop";
            this.buttonCopyLoop.Size                    =  new System.Drawing.Size(98, 23);
            this.buttonCopyLoop.TabIndex                =  20;
            this.buttonCopyLoop.Text                    =  "Copy to all other";
            this.buttonCopyLoop.UseVisualStyleBackColor =  true;
            this.buttonCopyLoop.Click                   += new System.EventHandler(this.buttonCopyLoop_Click);
            // 
            // groupBoxLoopDuration
            // 
            this.groupBoxLoopDuration.Controls.Add(this.textBoxLoopDurationSeconds);
            this.groupBoxLoopDuration.Controls.Add(this.textBoxLoopDurationSamples);
            this.groupBoxLoopDuration.Location = new System.Drawing.Point(100, 105);
            this.groupBoxLoopDuration.Name     = "groupBoxLoopDuration";
            this.groupBoxLoopDuration.Size     = new System.Drawing.Size(227, 39);
            this.groupBoxLoopDuration.TabIndex = 25;
            this.groupBoxLoopDuration.TabStop  = false;
            // 
            // textBoxLoopDurationSeconds
            // 
            this.textBoxLoopDurationSeconds.Location    =  new System.Drawing.Point(6, 10);
            this.textBoxLoopDurationSeconds.Name        =  "textBoxLoopDurationSeconds";
            this.textBoxLoopDurationSeconds.Size        =  new System.Drawing.Size(98, 20);
            this.textBoxLoopDurationSeconds.TabIndex    =  13;
            this.textBoxLoopDurationSeconds.TextChanged += new System.EventHandler(this.textBoxLoopDurationSeconds_TextChanged);
            // 
            // textBoxLoopDurationSamples
            // 
            this.textBoxLoopDurationSamples.Location    =  new System.Drawing.Point(122, 10);
            this.textBoxLoopDurationSamples.Name        =  "textBoxLoopDurationSamples";
            this.textBoxLoopDurationSamples.Size        =  new System.Drawing.Size(98, 20);
            this.textBoxLoopDurationSamples.TabIndex    =  21;
            this.textBoxLoopDurationSamples.TextChanged += new System.EventHandler(this.textBoxLoopDurationSamples_TextChanged);
            // 
            // groupBoxLoopStart
            // 
            this.groupBoxLoopStart.Controls.Add(this.textBoxLoopStartSeconds);
            this.groupBoxLoopStart.Controls.Add(this.textBoxLoopStartSamples);
            this.groupBoxLoopStart.Location = new System.Drawing.Point(100, 60);
            this.groupBoxLoopStart.Name     = "groupBoxLoopStart";
            this.groupBoxLoopStart.Size     = new System.Drawing.Size(227, 39);
            this.groupBoxLoopStart.TabIndex = 24;
            this.groupBoxLoopStart.TabStop  = false;
            // 
            // textBoxLoopStartSeconds
            // 
            this.textBoxLoopStartSeconds.Location    =  new System.Drawing.Point(6, 10);
            this.textBoxLoopStartSeconds.Name        =  "textBoxLoopStartSeconds";
            this.textBoxLoopStartSeconds.Size        =  new System.Drawing.Size(98, 20);
            this.textBoxLoopStartSeconds.TabIndex    =  13;
            this.textBoxLoopStartSeconds.TextChanged += new System.EventHandler(this.textBoxLoopStartSeconds_TextChanged);
            // 
            // textBoxLoopStartSamples
            // 
            this.textBoxLoopStartSamples.Location    =  new System.Drawing.Point(122, 10);
            this.textBoxLoopStartSamples.Name        =  "textBoxLoopStartSamples";
            this.textBoxLoopStartSamples.Size        =  new System.Drawing.Size(98, 20);
            this.textBoxLoopStartSamples.TabIndex    =  21;
            this.textBoxLoopStartSamples.TextChanged += new System.EventHandler(this.textBoxLoopStartSamples_TextChanged);
            // 
            // label13
            // 
            this.label13.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location  = new System.Drawing.Point(6, 113);
            this.label13.Name      = "label13";
            this.label13.Size      = new System.Drawing.Size(88, 23);
            this.label13.TabIndex  = 20;
            this.label13.Text      = "Loop duration:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location  = new System.Drawing.Point(216, 15);
            this.label12.Name      = "label12";
            this.label12.Size      = new System.Drawing.Size(98, 23);
            this.label12.TabIndex  = 19;
            this.label12.Text      = "Samples";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location  = new System.Drawing.Point(100, 16);
            this.label11.Name      = "label11";
            this.label11.Size      = new System.Drawing.Size(98, 23);
            this.label11.TabIndex  = 18;
            this.label11.Text      = "Seconds";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location  = new System.Drawing.Point(6, 68);
            this.label10.Name      = "label10";
            this.label10.Size      = new System.Drawing.Size(88, 23);
            this.label10.TabIndex  = 17;
            this.label10.Text      = "Loop start:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location  = new System.Drawing.Point(6, 149);
            this.label7.Name      = "label7";
            this.label7.Size      = new System.Drawing.Size(94, 23);
            this.label7.TabIndex  = 15;
            this.label7.Text      = "Loop settings for:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // domainUpDownLoopNote
            // 
            this.domainUpDownLoopNote.Items.Add("C");
            this.domainUpDownLoopNote.Items.Add("D");
            this.domainUpDownLoopNote.Items.Add("E");
            this.domainUpDownLoopNote.Items.Add("F");
            this.domainUpDownLoopNote.Items.Add("G");
            this.domainUpDownLoopNote.Location            =  new System.Drawing.Point(112, 152);
            this.domainUpDownLoopNote.Name                =  "domainUpDownLoopNote";
            this.domainUpDownLoopNote.Size                =  new System.Drawing.Size(50, 20);
            this.domainUpDownLoopNote.TabIndex            =  0;
            this.domainUpDownLoopNote.SelectedItemChanged += new System.EventHandler(this.domainUpDownLoopNote_SelectedItemChanged);
            // 
            // label6
            // 
            this.label6.Font      = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location  = new System.Drawing.Point(6, 16);
            this.label6.Name      = "label6";
            this.label6.Size      = new System.Drawing.Size(104, 23);
            this.label6.TabIndex  = 15;
            this.label6.Text      = "Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxInstrumentName
            // 
            this.textBoxInstrumentName.Location    =  new System.Drawing.Point(112, 18);
            this.textBoxInstrumentName.Name        =  "textBoxInstrumentName";
            this.textBoxInstrumentName.Size        =  new System.Drawing.Size(507, 20);
            this.textBoxInstrumentName.TabIndex    =  8;
            this.textBoxInstrumentName.TextChanged += new System.EventHandler(this.textBoxInstrumentName_TextChanged);
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.Location                =  new System.Drawing.Point(6, 159);
            this.checkBoxLoop.Name                    =  "checkBoxLoop";
            this.checkBoxLoop.Size                    =  new System.Drawing.Size(69, 24);
            this.checkBoxLoop.TabIndex                =  0;
            this.checkBoxLoop.Text                    =  "Loop";
            this.checkBoxLoop.UseVisualStyleBackColor =  true;
            this.checkBoxLoop.CheckedChanged          += new System.EventHandler(this.checkBoxLoop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1421, 684);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxInstrument);
            this.Controls.Add(this.groupBoxDir);
            this.Name =  "Form1";
            this.Text =  "Smanip";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxSrcDir.ResumeLayout(false);
            this.groupBoxWav.ResumeLayout(false);
            this.groupBoxWav.PerformLayout();
            this.groupBoxScaling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalePitch)).EndInit();
            this.groupBoxDir.ResumeLayout(false);
            this.groupBoxDir.PerformLayout();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.groupBoxInstrument.ResumeLayout(false);
            this.groupBoxInstrument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTranspose)).EndInit();
            this.groupBoxLoop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxLoopDuration.ResumeLayout(false);
            this.groupBoxLoopDuration.PerformLayout();
            this.groupBoxLoopStart.ResumeLayout(false);
            this.groupBoxLoopStart.PerformLayout();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button        buttonCopyLoop;
        private System.Windows.Forms.Label         label15;
        private System.Windows.Forms.NumericUpDown numericUpDownFade;
        private System.Windows.Forms.NumericUpDown numericUpDownTranspose;
        private System.Windows.Forms.Button        buttonTranspose;
        private System.Windows.Forms.DomainUpDown  domainUpDownVelocity;
        private System.Windows.Forms.Label         label14;
        private System.Windows.Forms.Label         label12;
        private System.Windows.Forms.Label         label13;
        private System.Windows.Forms.TextBox       textBoxLoopStartSeconds;
        private System.Windows.Forms.TextBox       textBoxLoopStartSamples;
        private System.Windows.Forms.GroupBox      groupBoxLoopStart;
        private System.Windows.Forms.GroupBox      groupBoxLoopDuration;
        private System.Windows.Forms.TextBox       textBoxLoopDurationSeconds;
        private System.Windows.Forms.TextBox       textBoxLoopDurationSamples;
        private System.Windows.Forms.Button        buttonLoopAllUntilEnd;
        private System.Windows.Forms.Label         label7;
        private System.Windows.Forms.GroupBox      groupBox1;
        private System.Windows.Forms.Label         label10;
        private System.Windows.Forms.Label         label11;
        private System.Windows.Forms.Button        buttonConfigSave;
        private System.Windows.Forms.DomainUpDown  domainUpDownLoopNote;
        private System.Windows.Forms.Button        buttonPitchShift;
        private System.Windows.Forms.Label         labelNoteStatus;
        private System.Windows.Forms.GroupBox      groupBoxLoop;
        private System.Windows.Forms.TextBox       textBoxInstrumentName;
        private System.Windows.Forms.Label         label6;
        private System.Windows.Forms.CheckBox      checkBoxLoop;
        private System.Windows.Forms.GroupBox      groupBoxInstrument;
        private System.Windows.Forms.Label         labelFormat;
        private System.Windows.Forms.Label         labelNcwToWavStatus;
        private System.Windows.Forms.Label         labelExtractStatus;
        private System.Windows.Forms.Button        buttonExtract;
        private System.Windows.Forms.GroupBox      groupBoxDir;
        private System.Windows.Forms.GroupBox      groupBoxFile;
        private System.Windows.Forms.Label         label3;
        private System.Windows.Forms.Label         labelSrcFileValid;
        private System.Windows.Forms.Button        buttonSrcFileBrowse;
        private System.Windows.Forms.TextBox       textBoxSrcFile;
        private System.Windows.Forms.Label         label9;
        private System.Windows.Forms.NumericUpDown numericUpDownScalePitch;
        private System.Windows.Forms.GroupBox      groupBoxScaling;
        private System.Windows.Forms.CheckBox      checkBoxAutoScaleVelocity;
        private System.Windows.Forms.Label         label8;
        private System.Windows.Forms.Label         labelSrcDirValid;
        private System.Windows.Forms.Label         labelDstDirValid;
        private System.Windows.Forms.Button        buttonDstDirBrowse;
        private System.Windows.Forms.TextBox       textBoxDstDir;
        private System.Windows.Forms.Label         label5;
        private System.Windows.Forms.Button        buttonRun;
        private System.Windows.Forms.TextBox       textBoxPattern;
        private System.Windows.Forms.Label         label4;
        private System.Windows.Forms.GroupBox      groupBoxWav;
        private System.Windows.Forms.Button        buttonConvertNcwToWav;
        private System.Windows.Forms.Label         label1;
        private System.Windows.Forms.Label         labelSrcType;
        private System.Windows.Forms.GroupBox      groupBoxSrcDir;
        private System.Windows.Forms.TextBox       textBoxSrcDir;
        private System.Windows.Forms.Label         label2;
        private System.Windows.Forms.Button        buttonSrcDirBrowse;

        #endregion

    }
}