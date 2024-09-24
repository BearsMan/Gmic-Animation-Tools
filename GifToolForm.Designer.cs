namespace GmicAnimate
{
    partial class ToolForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolForm));
            buttonOpenFile = new System.Windows.Forms.Button();
            txtAnalysisOutput = new System.Windows.Forms.TextBox();
            txtGifFilePath = new System.Windows.Forms.TextBox();
            labelGifFilePath = new System.Windows.Forms.Label();
            labelAnalysisOutput = new System.Windows.Forms.Label();
            buttonImportAnotherFolder = new System.Windows.Forms.Button();
            labelFramesFolderPath = new System.Windows.Forms.Label();
            txtFramesFolderPath = new System.Windows.Forms.TextBox();
            buttonOpenFolder = new System.Windows.Forms.Button();
            labelFramesFolderDetails = new System.Windows.Forms.Label();
            txtFramesFolderDetails = new System.Windows.Forms.TextBox();
            labelImportAnotherFolder = new System.Windows.Forms.Label();
            labelGifEditTitle = new System.Windows.Forms.Label();
            labelGifCreationTitle = new System.Windows.Forms.Label();
            labelFixFileSequence = new System.Windows.Forms.Label();
            buttonFixFileSequence = new System.Windows.Forms.Button();
            buttonCreateGifFromFolder = new System.Windows.Forms.Button();
            labelGifCreateStatus = new System.Windows.Forms.Label();
            buttonAddCrossfade = new System.Windows.Forms.Button();
            nudFadeDurationSeconds = new System.Windows.Forms.NumericUpDown();
            labelFadeDuration = new System.Windows.Forms.Label();
            labelCrossfadeStatus = new System.Windows.Forms.Label();
            LeftBorder = new System.Windows.Forms.Label();
            RightBorder = new System.Windows.Forms.Label();
            buttonCreationHelp = new System.Windows.Forms.Button();
            buttonEditHelp = new System.Windows.Forms.Button();
            dropdownFFmpegMode = new System.Windows.Forms.ComboBox();
            infoIconFFmpegMode = new System.Windows.Forms.PictureBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            infoIconAlphaThreshold = new System.Windows.Forms.PictureBox();
            labelCalcGifDuration = new System.Windows.Forms.Label();
            nudFrameRateSelect = new System.Windows.Forms.NumericUpDown();
            labelFrameRateSelect = new System.Windows.Forms.Label();
            btnViewOutputDirectory = new System.Windows.Forms.Button();
            btnCheckAlpha = new System.Windows.Forms.Button();
            nudAlphaThreshold = new System.Windows.Forms.NumericUpDown();
            labelAlphaThreshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nudFadeDurationSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconFFmpegMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconAlphaThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFrameRateSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAlphaThreshold).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new System.Drawing.Point(377, 140);
            buttonOpenFile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new System.Drawing.Size(126, 55);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Load GIF";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += btnOpenFile_Click;
            // 
            // txtAnalysisOutput
            // 
            txtAnalysisOutput.AcceptsReturn = true;
            txtAnalysisOutput.AcceptsTab = true;
            txtAnalysisOutput.Location = new System.Drawing.Point(47, 253);
            txtAnalysisOutput.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtAnalysisOutput.Multiline = true;
            txtAnalysisOutput.Name = "txtAnalysisOutput";
            txtAnalysisOutput.ReadOnly = true;
            txtAnalysisOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtAnalysisOutput.Size = new System.Drawing.Size(453, 121);
            txtAnalysisOutput.TabIndex = 1;
            // 
            // txtGifFilePath
            // 
            txtGifFilePath.Location = new System.Drawing.Point(47, 150);
            txtGifFilePath.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtGifFilePath.Name = "txtGifFilePath";
            txtGifFilePath.Size = new System.Drawing.Size(317, 31);
            txtGifFilePath.TabIndex = 2;
            txtGifFilePath.TextChanged += txtGifFilePath_TextChanged;
            // 
            // labelGifFilePath
            // 
            labelGifFilePath.AutoSize = true;
            labelGifFilePath.Location = new System.Drawing.Point(47, 120);
            labelGifFilePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelGifFilePath.Name = "labelGifFilePath";
            labelGifFilePath.Size = new System.Drawing.Size(112, 25);
            labelGifFilePath.TabIndex = 3;
            labelGifFilePath.Text = "GIF File Path:";
            // 
            // labelAnalysisOutput
            // 
            labelAnalysisOutput.AutoSize = true;
            labelAnalysisOutput.Location = new System.Drawing.Point(47, 223);
            labelAnalysisOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelAnalysisOutput.Name = "labelAnalysisOutput";
            labelAnalysisOutput.Size = new System.Drawing.Size(111, 25);
            labelAnalysisOutput.TabIndex = 4;
            labelAnalysisOutput.Text = "GIF Analysis:";
            // 
            // buttonImportAnotherFolder
            // 
            buttonImportAnotherFolder.Location = new System.Drawing.Point(884, 395);
            buttonImportAnotherFolder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonImportAnotherFolder.Name = "buttonImportAnotherFolder";
            buttonImportAnotherFolder.Size = new System.Drawing.Size(147, 45);
            buttonImportAnotherFolder.TabIndex = 5;
            buttonImportAnotherFolder.Text = "Import Folder";
            buttonImportAnotherFolder.UseVisualStyleBackColor = true;
            buttonImportAnotherFolder.Click += buttonImportAnotherFolder_Click;
            // 
            // labelFramesFolderPath
            // 
            labelFramesFolderPath.AutoSize = true;
            labelFramesFolderPath.Location = new System.Drawing.Point(577, 120);
            labelFramesFolderPath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelFramesFolderPath.Name = "labelFramesFolderPath";
            labelFramesFolderPath.Size = new System.Drawing.Size(222, 25);
            labelFramesFolderPath.TabIndex = 8;
            labelFramesFolderPath.Text = "Image Frames Folder Path:";
            // 
            // txtFramesFolderPath
            // 
            txtFramesFolderPath.Location = new System.Drawing.Point(577, 150);
            txtFramesFolderPath.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtFramesFolderPath.Name = "txtFramesFolderPath";
            txtFramesFolderPath.Size = new System.Drawing.Size(317, 31);
            txtFramesFolderPath.TabIndex = 7;
            txtFramesFolderPath.TextChanged += txtFramesFolderPath_TextChanged;
            // 
            // buttonOpenFolder
            // 
            buttonOpenFolder.Location = new System.Drawing.Point(907, 140);
            buttonOpenFolder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonOpenFolder.Name = "buttonOpenFolder";
            buttonOpenFolder.Size = new System.Drawing.Size(126, 55);
            buttonOpenFolder.TabIndex = 6;
            buttonOpenFolder.Text = "Load Folder";
            buttonOpenFolder.UseVisualStyleBackColor = true;
            buttonOpenFolder.Click += buttonOpenFolder_Click;
            // 
            // labelFramesFolderDetails
            // 
            labelFramesFolderDetails.AutoSize = true;
            labelFramesFolderDetails.Location = new System.Drawing.Point(577, 223);
            labelFramesFolderDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelFramesFolderDetails.Name = "labelFramesFolderDetails";
            labelFramesFolderDetails.Size = new System.Drawing.Size(69, 25);
            labelFramesFolderDetails.TabIndex = 10;
            labelFramesFolderDetails.Text = "Details:";
            // 
            // txtFramesFolderDetails
            // 
            txtFramesFolderDetails.AcceptsReturn = true;
            txtFramesFolderDetails.AcceptsTab = true;
            txtFramesFolderDetails.Location = new System.Drawing.Point(577, 253);
            txtFramesFolderDetails.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtFramesFolderDetails.Multiline = true;
            txtFramesFolderDetails.Name = "txtFramesFolderDetails";
            txtFramesFolderDetails.ReadOnly = true;
            txtFramesFolderDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtFramesFolderDetails.Size = new System.Drawing.Size(453, 121);
            txtFramesFolderDetails.TabIndex = 9;
            txtFramesFolderDetails.TextChanged += txtFramesFolderDetails_TextChanged;
            // 
            // labelImportAnotherFolder
            // 
            labelImportAnotherFolder.AutoSize = true;
            labelImportAnotherFolder.Location = new System.Drawing.Point(577, 403);
            labelImportAnotherFolder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelImportAnotherFolder.Name = "labelImportAnotherFolder";
            labelImportAnotherFolder.Size = new System.Drawing.Size(305, 25);
            labelImportAnotherFolder.TabIndex = 11;
            labelImportAnotherFolder.Text = "Merge Frames From Another Folder: ";
            // 
            // labelGifEditTitle
            // 
            labelGifEditTitle.AutoSize = true;
            labelGifEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelGifEditTitle.Location = new System.Drawing.Point(174, 37);
            labelGifEditTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelGifEditTitle.Name = "labelGifEditTitle";
            labelGifEditTitle.Size = new System.Drawing.Size(194, 32);
            labelGifEditTitle.TabIndex = 12;
            labelGifEditTitle.Text = "GIF Edit Tools";
            // 
            // labelGifCreationTitle
            // 
            labelGifCreationTitle.AutoSize = true;
            labelGifCreationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            labelGifCreationTitle.Location = new System.Drawing.Point(671, 37);
            labelGifCreationTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelGifCreationTitle.Name = "labelGifCreationTitle";
            labelGifCreationTitle.Size = new System.Drawing.Size(252, 32);
            labelGifCreationTitle.TabIndex = 13;
            labelGifCreationTitle.Text = "GIF Creation Tools";
            // 
            // labelFixFileSequence
            // 
            labelFixFileSequence.AutoSize = true;
            labelFixFileSequence.Location = new System.Drawing.Point(618, 462);
            labelFixFileSequence.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelFixFileSequence.Name = "labelFixFileSequence";
            labelFixFileSequence.Size = new System.Drawing.Size(254, 25);
            labelFixFileSequence.TabIndex = 14;
            labelFixFileSequence.Text = "Fix File Sequencing && Padding:";
            // 
            // buttonFixFileSequence
            // 
            buttonFixFileSequence.Location = new System.Drawing.Point(884, 452);
            buttonFixFileSequence.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonFixFileSequence.Name = "buttonFixFileSequence";
            buttonFixFileSequence.Size = new System.Drawing.Size(147, 45);
            buttonFixFileSequence.TabIndex = 15;
            buttonFixFileSequence.Text = "Fix";
            buttonFixFileSequence.UseVisualStyleBackColor = true;
            buttonFixFileSequence.Click += buttonFixFileSequence_Click;
            // 
            // buttonCreateGifFromFolder
            // 
            buttonCreateGifFromFolder.Location = new System.Drawing.Point(577, 662);
            buttonCreateGifFromFolder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonCreateGifFromFolder.Name = "buttonCreateGifFromFolder";
            buttonCreateGifFromFolder.Size = new System.Drawing.Size(234, 72);
            buttonCreateGifFromFolder.TabIndex = 16;
            buttonCreateGifFromFolder.Text = "Create GIF From Folder";
            buttonCreateGifFromFolder.UseVisualStyleBackColor = true;
            buttonCreateGifFromFolder.Click += buttonCreateGifFromFolder_Click;
            // 
            // labelGifCreateStatus
            // 
            labelGifCreateStatus.AutoSize = true;
            labelGifCreateStatus.Location = new System.Drawing.Point(577, 738);
            labelGifCreateStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelGifCreateStatus.Name = "labelGifCreateStatus";
            labelGifCreateStatus.Size = new System.Drawing.Size(60, 25);
            labelGifCreateStatus.TabIndex = 17;
            labelGifCreateStatus.Text = "Status";
            labelGifCreateStatus.Visible = false;
            // 
            // buttonAddCrossfade
            // 
            buttonAddCrossfade.Location = new System.Drawing.Point(47, 485);
            buttonAddCrossfade.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonAddCrossfade.Name = "buttonAddCrossfade";
            buttonAddCrossfade.Size = new System.Drawing.Size(213, 45);
            buttonAddCrossfade.TabIndex = 21;
            buttonAddCrossfade.Text = "Add Loop Crossfade";
            buttonAddCrossfade.UseVisualStyleBackColor = true;
            buttonAddCrossfade.Click += buttonAddCrossfade_Click;
            // 
            // nudFadeDurationSeconds
            // 
            nudFadeDurationSeconds.DecimalPlaces = 2;
            nudFadeDurationSeconds.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudFadeDurationSeconds.Location = new System.Drawing.Point(270, 428);
            nudFadeDurationSeconds.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nudFadeDurationSeconds.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFadeDurationSeconds.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            nudFadeDurationSeconds.Name = "nudFadeDurationSeconds";
            nudFadeDurationSeconds.Size = new System.Drawing.Size(89, 31);
            nudFadeDurationSeconds.TabIndex = 22;
            nudFadeDurationSeconds.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudFadeDurationSeconds.ValueChanged += nudFadeDurationSeconds_ValueChanged;
            // 
            // labelFadeDuration
            // 
            labelFadeDuration.AutoSize = true;
            labelFadeDuration.Location = new System.Drawing.Point(47, 435);
            labelFadeDuration.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelFadeDuration.Name = "labelFadeDuration";
            labelFadeDuration.Size = new System.Drawing.Size(209, 25);
            labelFadeDuration.TabIndex = 23;
            labelFadeDuration.Text = "Fade Duration (Seconds):";
            // 
            // labelCrossfadeStatus
            // 
            labelCrossfadeStatus.AutoSize = true;
            labelCrossfadeStatus.Location = new System.Drawing.Point(49, 542);
            labelCrossfadeStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelCrossfadeStatus.Name = "labelCrossfadeStatus";
            labelCrossfadeStatus.Size = new System.Drawing.Size(60, 25);
            labelCrossfadeStatus.TabIndex = 24;
            labelCrossfadeStatus.Text = "Status";
            labelCrossfadeStatus.Visible = false;
            // 
            // LeftBorder
            // 
            LeftBorder.BackColor = System.Drawing.Color.Transparent;
            LeftBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LeftBorder.Location = new System.Drawing.Point(20, 17);
            LeftBorder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            LeftBorder.Name = "LeftBorder";
            LeftBorder.Size = new System.Drawing.Size(502, 807);
            LeftBorder.TabIndex = 25;
            // 
            // RightBorder
            // 
            RightBorder.BackColor = System.Drawing.Color.Transparent;
            RightBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            RightBorder.Location = new System.Drawing.Point(559, 17);
            RightBorder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            RightBorder.Name = "RightBorder";
            RightBorder.Size = new System.Drawing.Size(493, 807);
            RightBorder.TabIndex = 26;
            // 
            // buttonCreationHelp
            // 
            buttonCreationHelp.Location = new System.Drawing.Point(907, 755);
            buttonCreationHelp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonCreationHelp.Name = "buttonCreationHelp";
            buttonCreationHelp.Size = new System.Drawing.Size(126, 45);
            buttonCreationHelp.TabIndex = 27;
            buttonCreationHelp.Text = "Help";
            buttonCreationHelp.UseVisualStyleBackColor = true;
            buttonCreationHelp.Click += buttonCreationHelp_Click;
            // 
            // buttonEditHelp
            // 
            buttonEditHelp.Location = new System.Drawing.Point(377, 755);
            buttonEditHelp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonEditHelp.Name = "buttonEditHelp";
            buttonEditHelp.Size = new System.Drawing.Size(126, 45);
            buttonEditHelp.TabIndex = 28;
            buttonEditHelp.Text = "Help";
            buttonEditHelp.UseVisualStyleBackColor = true;
            buttonEditHelp.Click += buttonEditHelp_Click;
            // 
            // dropdownFFmpegMode
            // 
            dropdownFFmpegMode.FormattingEnabled = true;
            dropdownFFmpegMode.Items.AddRange(new object[] { "FFMPEG Mode 1", "FFMPEG Mode 2" });
            dropdownFFmpegMode.Location = new System.Drawing.Point(821, 683);
            dropdownFFmpegMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dropdownFFmpegMode.Name = "dropdownFFmpegMode";
            dropdownFFmpegMode.Size = new System.Drawing.Size(177, 33);
            dropdownFFmpegMode.TabIndex = 29;
            // 
            // infoIconFFmpegMode
            // 
            infoIconFFmpegMode.Image = (System.Drawing.Image)resources.GetObject("infoIconFFmpegMode.Image");
            infoIconFFmpegMode.Location = new System.Drawing.Point(1003, 692);
            infoIconFFmpegMode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconFFmpegMode.Name = "infoIconFFmpegMode";
            infoIconFFmpegMode.Size = new System.Drawing.Size(16, 16);
            infoIconFFmpegMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconFFmpegMode.TabIndex = 38;
            infoIconFFmpegMode.TabStop = false;
            toolTip1.SetToolTip(infoIconFFmpegMode, resources.GetString("infoIconFFmpegMode.ToolTip"));
            // 
            // infoIconAlphaThreshold
            // 
            infoIconAlphaThreshold.Image = (System.Drawing.Image)resources.GetObject("infoIconAlphaThreshold.Image");
            infoIconAlphaThreshold.Location = new System.Drawing.Point(762, 554);
            infoIconAlphaThreshold.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconAlphaThreshold.Name = "infoIconAlphaThreshold";
            infoIconAlphaThreshold.Size = new System.Drawing.Size(16, 16);
            infoIconAlphaThreshold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconAlphaThreshold.TabIndex = 43;
            infoIconAlphaThreshold.TabStop = false;
            toolTip1.SetToolTip(infoIconAlphaThreshold, resources.GetString("infoIconAlphaThreshold.ToolTip"));
            // 
            // labelCalcGifDuration
            // 
            labelCalcGifDuration.AutoSize = true;
            labelCalcGifDuration.Location = new System.Drawing.Point(870, 640);
            labelCalcGifDuration.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelCalcGifDuration.Name = "labelCalcGifDuration";
            labelCalcGifDuration.Size = new System.Drawing.Size(164, 25);
            labelCalcGifDuration.TabIndex = 20;
            labelCalcGifDuration.Text = "Total Duration: N/A";
            // 
            // nudFrameRateSelect
            // 
            nudFrameRateSelect.Location = new System.Drawing.Point(934, 597);
            nudFrameRateSelect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nudFrameRateSelect.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            nudFrameRateSelect.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudFrameRateSelect.Name = "nudFrameRateSelect";
            nudFrameRateSelect.Size = new System.Drawing.Size(91, 31);
            nudFrameRateSelect.TabIndex = 18;
            nudFrameRateSelect.Value = new decimal(new int[] { 25, 0, 0, 0 });
            nudFrameRateSelect.ValueChanged += nudFrameRateSelect_ValueChanged;
            // 
            // labelFrameRateSelect
            // 
            labelFrameRateSelect.AutoSize = true;
            labelFrameRateSelect.Location = new System.Drawing.Point(756, 599);
            labelFrameRateSelect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelFrameRateSelect.Name = "labelFrameRateSelect";
            labelFrameRateSelect.Size = new System.Drawing.Size(166, 25);
            labelFrameRateSelect.TabIndex = 19;
            labelFrameRateSelect.Text = "Frames Per Second:";
            labelFrameRateSelect.Click += labelFrameRateSelect_Click;
            // 
            // btnViewOutputDirectory
            // 
            btnViewOutputDirectory.Enabled = false;
            btnViewOutputDirectory.Location = new System.Drawing.Point(837, 207);
            btnViewOutputDirectory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnViewOutputDirectory.Name = "btnViewOutputDirectory";
            btnViewOutputDirectory.Size = new System.Drawing.Size(194, 37);
            btnViewOutputDirectory.TabIndex = 39;
            btnViewOutputDirectory.Text = "View Output Directory";
            btnViewOutputDirectory.UseVisualStyleBackColor = true;
            btnViewOutputDirectory.Click += btnViewOutputDirectory_Click;
            // 
            // btnCheckAlpha
            // 
            btnCheckAlpha.Location = new System.Drawing.Point(34, 762);
            btnCheckAlpha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCheckAlpha.Name = "btnCheckAlpha";
            btnCheckAlpha.Size = new System.Drawing.Size(211, 38);
            btnCheckAlpha.TabIndex = 40;
            btnCheckAlpha.Text = "Check Alpha Channel";
            btnCheckAlpha.UseVisualStyleBackColor = true;
            btnCheckAlpha.Visible = false;
            btnCheckAlpha.Click += btnCheckAlpha_Click;
            // 
            // nudAlphaThreshold
            // 
            nudAlphaThreshold.Location = new System.Drawing.Point(934, 542);
            nudAlphaThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            nudAlphaThreshold.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudAlphaThreshold.Name = "nudAlphaThreshold";
            nudAlphaThreshold.Size = new System.Drawing.Size(91, 31);
            nudAlphaThreshold.TabIndex = 41;
            nudAlphaThreshold.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelAlphaThreshold
            // 
            labelAlphaThreshold.AutoSize = true;
            labelAlphaThreshold.Location = new System.Drawing.Point(781, 548);
            labelAlphaThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAlphaThreshold.Name = "labelAlphaThreshold";
            labelAlphaThreshold.Size = new System.Drawing.Size(145, 25);
            labelAlphaThreshold.TabIndex = 42;
            labelAlphaThreshold.Text = "Alpha Threshold:";
            // 
            // ToolForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1063, 840);
            Controls.Add(infoIconAlphaThreshold);
            Controls.Add(labelAlphaThreshold);
            Controls.Add(nudAlphaThreshold);
            Controls.Add(btnCheckAlpha);
            Controls.Add(btnViewOutputDirectory);
            Controls.Add(infoIconFFmpegMode);
            Controls.Add(dropdownFFmpegMode);
            Controls.Add(buttonEditHelp);
            Controls.Add(buttonCreationHelp);
            Controls.Add(labelCrossfadeStatus);
            Controls.Add(labelFadeDuration);
            Controls.Add(nudFadeDurationSeconds);
            Controls.Add(buttonAddCrossfade);
            Controls.Add(labelCalcGifDuration);
            Controls.Add(labelFrameRateSelect);
            Controls.Add(nudFrameRateSelect);
            Controls.Add(labelGifCreateStatus);
            Controls.Add(buttonCreateGifFromFolder);
            Controls.Add(buttonFixFileSequence);
            Controls.Add(labelFixFileSequence);
            Controls.Add(labelGifCreationTitle);
            Controls.Add(labelGifEditTitle);
            Controls.Add(labelImportAnotherFolder);
            Controls.Add(labelFramesFolderDetails);
            Controls.Add(txtFramesFolderDetails);
            Controls.Add(labelFramesFolderPath);
            Controls.Add(txtFramesFolderPath);
            Controls.Add(buttonOpenFolder);
            Controls.Add(buttonImportAnotherFolder);
            Controls.Add(labelAnalysisOutput);
            Controls.Add(labelGifFilePath);
            Controls.Add(txtGifFilePath);
            Controls.Add(txtAnalysisOutput);
            Controls.Add(buttonOpenFile);
            Controls.Add(LeftBorder);
            Controls.Add(RightBorder);
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "ToolForm";
            Text = "GIF Tools";
            ((System.ComponentModel.ISupportInitialize)nudFadeDurationSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconFFmpegMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconAlphaThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFrameRateSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAlphaThreshold).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox txtAnalysisOutput;
        private System.Windows.Forms.TextBox txtGifFilePath;
        private System.Windows.Forms.Label labelGifFilePath;
        private System.Windows.Forms.Label labelAnalysisOutput;
        private System.Windows.Forms.Button buttonImportAnotherFolder;
        private System.Windows.Forms.Label labelFramesFolderPath;
        private System.Windows.Forms.TextBox txtFramesFolderPath;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label labelFramesFolderDetails;
        private System.Windows.Forms.TextBox txtFramesFolderDetails;
        private System.Windows.Forms.Label labelImportAnotherFolder;
        private System.Windows.Forms.Label labelGifEditTitle;
        private System.Windows.Forms.Label labelGifCreationTitle;
        private System.Windows.Forms.Label labelFixFileSequence;
        private System.Windows.Forms.Button buttonFixFileSequence;
        private System.Windows.Forms.Button buttonCreateGifFromFolder;
        private System.Windows.Forms.Label labelGifCreateStatus;
        private System.Windows.Forms.Button buttonAddCrossfade;
        private System.Windows.Forms.NumericUpDown nudFadeDurationSeconds;
        private System.Windows.Forms.Label labelFadeDuration;
        private System.Windows.Forms.Label labelCrossfadeStatus;
        private System.Windows.Forms.Label LeftBorder;
        private System.Windows.Forms.Label RightBorder;
        private System.Windows.Forms.Button buttonCreationHelp;
        private System.Windows.Forms.Button buttonEditHelp;
        private System.Windows.Forms.ComboBox dropdownFFmpegMode;
        private System.Windows.Forms.PictureBox infoIconFFmpegMode;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelCalcGifDuration;
        private System.Windows.Forms.NumericUpDown nudFrameRateSelect;
        private System.Windows.Forms.Label labelFrameRateSelect;
        private System.Windows.Forms.Button btnViewOutputDirectory;
        private System.Windows.Forms.Button btnCheckAlpha;
        private System.Windows.Forms.NumericUpDown nudAlphaThreshold;
        private System.Windows.Forms.Label labelAlphaThreshold;
        private System.Windows.Forms.PictureBox infoIconAlphaThreshold;
    }
}

