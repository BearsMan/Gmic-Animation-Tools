namespace GmicFilterAnimatorApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            nudTotalFrames = new InvisibleNumericUpDown();
            nudMasterParamIncrement = new InvisibleNumericUpDown();
            lblInputFile = new System.Windows.Forms.Label();
            txtInputFilePath = new System.Windows.Forms.TextBox();
            btnSelectInputFile = new System.Windows.Forms.Button();
            lblStartParams = new System.Windows.Forms.Label();
            txtStartParams = new System.Windows.Forms.TextBox();
            lblEndParams = new System.Windows.Forms.Label();
            txtEndParams = new System.Windows.Forms.TextBox();
            lblMasterParamIndex = new System.Windows.Forms.Label();
            nudMasterParamIndex = new System.Windows.Forms.NumericUpDown();
            lblMasterParamIncrement = new System.Windows.Forms.Label();
            rbNoExponents = new System.Windows.Forms.RadioButton();
            rbMasterExponent = new System.Windows.Forms.RadioButton();
            rbDefaultExponents = new System.Windows.Forms.RadioButton();
            rbCustomExponents = new System.Windows.Forms.RadioButton();
            txtMasterExponent = new System.Windows.Forms.TextBox();
            txtExponentArray = new System.Windows.Forms.TextBox();
            chkCreateGif = new System.Windows.Forms.CheckBox();
            btnStart = new System.Windows.Forms.Button();
            btnViewOutputDirectory = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            InfoIconMasterParamIndex = new System.Windows.Forms.PictureBox();
            InfoIconMasterParamIncrement = new System.Windows.Forms.PictureBox();
            InfoIconMasterExponent = new System.Windows.Forms.PictureBox();
            InfoIconCustomExponents = new System.Windows.Forms.PictureBox();
            InfoIconDefaultExponents = new System.Windows.Forms.PictureBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            InfoIconLinearInterpolation = new System.Windows.Forms.PictureBox();
            InfoIconCreateGif = new System.Windows.Forms.PictureBox();
            infoIconUseSameDirectory = new System.Windows.Forms.PictureBox();
            checkBoxAbsoluteModeMain = new System.Windows.Forms.CheckBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            infoIconSingleThread = new System.Windows.Forms.PictureBox();
            infoIconRemoveBlankFrames = new System.Windows.Forms.PictureBox();
            infoIconFilterSearch = new System.Windows.Forms.PictureBox();
            infoIconAbsoluteModeMain = new System.Windows.Forms.PictureBox();
            btnShowParamNames = new System.Windows.Forms.Button();
            labelTotalFrames = new System.Windows.Forms.Label();
            TextLabelNearStartButton = new System.Windows.Forms.Label();
            labelMasterExponent = new System.Windows.Forms.Label();
            labelMasterParamName = new System.Windows.Forms.Label();
            checkBoxUseSameOutputDir = new System.Windows.Forms.CheckBox();
            btnSwapStartEndStrings = new System.Windows.Forms.Button();
            labelFFmpegNotFound = new System.Windows.Forms.Label();
            checkBoxLogOnly = new System.Windows.Forms.CheckBox();
            radioNormalizeStartEnd = new System.Windows.Forms.RadioButton();
            radioNormalizeMaxRanges = new System.Windows.Forms.RadioButton();
            radioNormalizeExtendedRanges = new System.Windows.Forms.RadioButton();
            radioNoNormalize = new System.Windows.Forms.RadioButton();
            groupBoxNormalizeRadios = new System.Windows.Forms.GroupBox();
            btnShowExpressionForm = new System.Windows.Forms.Button();
            btnLoadFilters = new System.Windows.Forms.Button();
            txtSearchBoxMain = new System.Windows.Forms.TextBox();
            listBoxFiltersMain = new System.Windows.Forms.ListBox();
            labelFilterSearch = new System.Windows.Forms.Label();
            dropdownDebugLog = new System.Windows.Forms.ComboBox();
            labelDebugLog = new System.Windows.Forms.Label();
            checkBoxSingleThreadMode = new System.Windows.Forms.CheckBox();
            toolStripActiveFilterLabel = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            progressBarGeneration = new System.Windows.Forms.ProgressBar();
            btnGifTools = new System.Windows.Forms.Button();
            checkBoxRemoveBlankFrames = new System.Windows.Forms.CheckBox();
            groupBoxOptions = new System.Windows.Forms.GroupBox();
            groupBoxAdvancedOptions = new System.Windows.Forms.GroupBox();
            groupBoxTools = new System.Windows.Forms.GroupBox();
            groupBoxInterpolation = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudTotalFrames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMasterParamIncrement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMasterParamIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconMasterParamIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconMasterParamIncrement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconMasterExponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconCustomExponents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconDefaultExponents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconLinearInterpolation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconCreateGif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconUseSameDirectory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconSingleThread).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconRemoveBlankFrames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconFilterSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconAbsoluteModeMain).BeginInit();
            groupBoxNormalizeRadios.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBoxOptions.SuspendLayout();
            groupBoxAdvancedOptions.SuspendLayout();
            groupBoxTools.SuspendLayout();
            groupBoxInterpolation.SuspendLayout();
            SuspendLayout();
            // 
            // nudTotalFrames
            // 
            nudTotalFrames.Location = new System.Drawing.Point(113, 315);
            nudTotalFrames.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nudTotalFrames.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudTotalFrames.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudTotalFrames.Name = "nudTotalFrames";
            nudTotalFrames.Size = new System.Drawing.Size(130, 31);
            nudTotalFrames.TabIndex = 28;
            nudTotalFrames.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudTotalFrames.ValueChanged += nudTotalFrames_ValueChanged;
            // 
            // nudMasterParamIncrement
            // 
            nudMasterParamIncrement.DecimalPlaces = 2;
            nudMasterParamIncrement.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudMasterParamIncrement.Location = new System.Drawing.Point(474, 318);
            nudMasterParamIncrement.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nudMasterParamIncrement.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMasterParamIncrement.Minimum = new decimal(new int[] { 1, 0, 0, 589824 });
            nudMasterParamIncrement.Name = "nudMasterParamIncrement";
            nudMasterParamIncrement.Size = new System.Drawing.Size(133, 31);
            nudMasterParamIncrement.TabIndex = 10;
            nudMasterParamIncrement.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudMasterParamIncrement.ValueChanged += nudMasterParamIncrement_ValueChanged;
            // 
            // lblInputFile
            // 
            lblInputFile.AutoSize = true;
            lblInputFile.Location = new System.Drawing.Point(26, 23);
            lblInputFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblInputFile.Name = "lblInputFile";
            lblInputFile.Size = new System.Drawing.Size(85, 25);
            lblInputFile.TabIndex = 0;
            lblInputFile.Text = "Input File";
            // 
            // txtInputFilePath
            // 
            txtInputFilePath.Location = new System.Drawing.Point(25, 53);
            txtInputFilePath.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtInputFilePath.Name = "txtInputFilePath";
            txtInputFilePath.ReadOnly = true;
            txtInputFilePath.Size = new System.Drawing.Size(497, 31);
            txtInputFilePath.TabIndex = 1;
            // 
            // btnSelectInputFile
            // 
            btnSelectInputFile.Location = new System.Drawing.Point(533, 48);
            btnSelectInputFile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnSelectInputFile.Name = "btnSelectInputFile";
            btnSelectInputFile.Size = new System.Drawing.Size(126, 36);
            btnSelectInputFile.TabIndex = 2;
            btnSelectInputFile.Text = "Select File";
            btnSelectInputFile.UseVisualStyleBackColor = true;
            btnSelectInputFile.Click += btnSelectInputFile_Click;
            // 
            // lblStartParams
            // 
            lblStartParams.AutoSize = true;
            lblStartParams.Location = new System.Drawing.Point(20, 99);
            lblStartParams.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblStartParams.Name = "lblStartParams";
            lblStartParams.Size = new System.Drawing.Size(216, 25);
            lblStartParams.TabIndex = 3;
            lblStartParams.Text = "Starting Parameter Values:";
            // 
            // txtStartParams
            // 
            txtStartParams.BackColor = System.Drawing.SystemColors.Window;
            txtStartParams.Location = new System.Drawing.Point(26, 131);
            txtStartParams.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtStartParams.Name = "txtStartParams";
            txtStartParams.Size = new System.Drawing.Size(633, 31);
            txtStartParams.TabIndex = 4;
            txtStartParams.TextChanged += txtStartParams_TextChanged;
            // 
            // lblEndParams
            // 
            lblEndParams.AutoSize = true;
            lblEndParams.Location = new System.Drawing.Point(20, 186);
            lblEndParams.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblEndParams.Name = "lblEndParams";
            lblEndParams.Size = new System.Drawing.Size(210, 25);
            lblEndParams.TabIndex = 5;
            lblEndParams.Text = "Ending Parameter Values:";
            // 
            // txtEndParams
            // 
            txtEndParams.Location = new System.Drawing.Point(26, 217);
            txtEndParams.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtEndParams.Name = "txtEndParams";
            txtEndParams.Size = new System.Drawing.Size(633, 31);
            txtEndParams.TabIndex = 6;
            txtEndParams.TextChanged += txtEndParams_TextChanged;
            // 
            // lblMasterParamIndex
            // 
            lblMasterParamIndex.AutoSize = true;
            lblMasterParamIndex.Location = new System.Drawing.Point(21, 272);
            lblMasterParamIndex.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblMasterParamIndex.Name = "lblMasterParamIndex";
            lblMasterParamIndex.Size = new System.Drawing.Size(202, 25);
            lblMasterParamIndex.TabIndex = 7;
            lblMasterParamIndex.Text = "Master Parameter Index:";
            // 
            // nudMasterParamIndex
            // 
            nudMasterParamIndex.Location = new System.Drawing.Point(227, 268);
            nudMasterParamIndex.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nudMasterParamIndex.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nudMasterParamIndex.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMasterParamIndex.Name = "nudMasterParamIndex";
            nudMasterParamIndex.Size = new System.Drawing.Size(83, 31);
            nudMasterParamIndex.TabIndex = 8;
            nudMasterParamIndex.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudMasterParamIndex.ValueChanged += nudMasterParamIndex_ValueChanged;
            // 
            // lblMasterParamIncrement
            // 
            lblMasterParamIncrement.AutoSize = true;
            lblMasterParamIncrement.Location = new System.Drawing.Point(249, 321);
            lblMasterParamIncrement.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblMasterParamIncrement.Name = "lblMasterParamIncrement";
            lblMasterParamIncrement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            lblMasterParamIncrement.Size = new System.Drawing.Size(222, 25);
            lblMasterParamIncrement.TabIndex = 9;
            lblMasterParamIncrement.Text = ".................Master Increment:";
            lblMasterParamIncrement.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbNoExponents
            // 
            rbNoExponents.AutoSize = true;
            rbNoExponents.Checked = true;
            rbNoExponents.Location = new System.Drawing.Point(28, 36);
            rbNoExponents.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            rbNoExponents.Name = "rbNoExponents";
            rbNoExponents.Size = new System.Drawing.Size(201, 29);
            rbNoExponents.TabIndex = 11;
            rbNoExponents.TabStop = true;
            rbNoExponents.Text = "Linear Interopolation";
            rbNoExponents.UseVisualStyleBackColor = true;
            rbNoExponents.CheckedChanged += rbNoExponents_CheckedChanged;
            // 
            // rbMasterExponent
            // 
            rbMasterExponent.AutoSize = true;
            rbMasterExponent.Location = new System.Drawing.Point(27, 75);
            rbMasterExponent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            rbMasterExponent.Name = "rbMasterExponent";
            rbMasterExponent.Size = new System.Drawing.Size(180, 29);
            rbMasterExponent.TabIndex = 12;
            rbMasterExponent.TabStop = true;
            rbMasterExponent.Text = "Master Expression";
            rbMasterExponent.UseVisualStyleBackColor = true;
            rbMasterExponent.CheckedChanged += rbMasterExponent_CheckedChanged;
            // 
            // rbDefaultExponents
            // 
            rbDefaultExponents.AutoSize = true;
            rbDefaultExponents.Location = new System.Drawing.Point(28, 153);
            rbDefaultExponents.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            rbDefaultExponents.Name = "rbDefaultExponents";
            rbDefaultExponents.Size = new System.Drawing.Size(181, 29);
            rbDefaultExponents.TabIndex = 13;
            rbDefaultExponents.TabStop = true;
            rbDefaultExponents.Text = "Default Exponents";
            rbDefaultExponents.UseVisualStyleBackColor = true;
            rbDefaultExponents.CheckedChanged += rbDefaultExponents_CheckedChanged;
            // 
            // rbCustomExponents
            // 
            rbCustomExponents.AutoSize = true;
            rbCustomExponents.Location = new System.Drawing.Point(28, 114);
            rbCustomExponents.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            rbCustomExponents.Name = "rbCustomExponents";
            rbCustomExponents.Size = new System.Drawing.Size(196, 29);
            rbCustomExponents.TabIndex = 14;
            rbCustomExponents.TabStop = true;
            rbCustomExponents.Text = "Custom Expressions";
            rbCustomExponents.UseVisualStyleBackColor = true;
            rbCustomExponents.CheckedChanged += rbCustomExponents_CheckedChanged;
            // 
            // txtMasterExponent
            // 
            txtMasterExponent.Enabled = false;
            txtMasterExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            txtMasterExponent.Location = new System.Drawing.Point(227, 75);
            txtMasterExponent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtMasterExponent.Name = "txtMasterExponent";
            txtMasterExponent.Size = new System.Drawing.Size(177, 29);
            txtMasterExponent.TabIndex = 16;
            txtMasterExponent.TextChanged += txtMasterExponent_TextChanged;
            // 
            // txtExponentArray
            // 
            txtExponentArray.Enabled = false;
            txtExponentArray.Location = new System.Drawing.Point(228, 114);
            txtExponentArray.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtExponentArray.Name = "txtExponentArray";
            txtExponentArray.Size = new System.Drawing.Size(393, 31);
            txtExponentArray.TabIndex = 18;
            txtExponentArray.TextChanged += txtExponentArray_TextChanged;
            // 
            // chkCreateGif
            // 
            chkCreateGif.AutoSize = true;
            chkCreateGif.Checked = true;
            chkCreateGif.CheckState = System.Windows.Forms.CheckState.Checked;
            chkCreateGif.Location = new System.Drawing.Point(34, 112);
            chkCreateGif.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            chkCreateGif.Name = "chkCreateGif";
            chkCreateGif.Size = new System.Drawing.Size(119, 29);
            chkCreateGif.TabIndex = 16;
            chkCreateGif.Text = "Create GIF";
            chkCreateGif.UseVisualStyleBackColor = true;
            chkCreateGif.CheckedChanged += chkCreateGif_CheckedChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new System.Drawing.Point(96, 609);
            btnStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(293, 58);
            btnStart.TabIndex = 17;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnViewOutputDirectory
            // 
            btnViewOutputDirectory.Location = new System.Drawing.Point(436, 609);
            btnViewOutputDirectory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnViewOutputDirectory.Name = "btnViewOutputDirectory";
            btnViewOutputDirectory.Size = new System.Drawing.Size(155, 91);
            btnViewOutputDirectory.TabIndex = 18;
            btnViewOutputDirectory.Text = "View Output Directory";
            btnViewOutputDirectory.UseVisualStyleBackColor = true;
            btnViewOutputDirectory.Click += btnViewOutputDirectory_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(96, 609);
            btnCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(200, 58);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // InfoIconMasterParamIndex
            // 
            InfoIconMasterParamIndex.Image = (System.Drawing.Image)resources.GetObject("InfoIconMasterParamIndex.Image");
            InfoIconMasterParamIndex.Location = new System.Drawing.Point(315, 275);
            InfoIconMasterParamIndex.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            InfoIconMasterParamIndex.Name = "InfoIconMasterParamIndex";
            InfoIconMasterParamIndex.Size = new System.Drawing.Size(16, 16);
            InfoIconMasterParamIndex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            InfoIconMasterParamIndex.TabIndex = 20;
            InfoIconMasterParamIndex.TabStop = false;
            toolTip1.SetToolTip(InfoIconMasterParamIndex, resources.GetString("InfoIconMasterParamIndex.ToolTip"));
            // 
            // InfoIconMasterParamIncrement
            // 
            InfoIconMasterParamIncrement.Image = (System.Drawing.Image)resources.GetObject("InfoIconMasterParamIncrement.Image");
            InfoIconMasterParamIncrement.Location = new System.Drawing.Point(615, 327);
            InfoIconMasterParamIncrement.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            InfoIconMasterParamIncrement.Name = "InfoIconMasterParamIncrement";
            InfoIconMasterParamIncrement.Size = new System.Drawing.Size(16, 16);
            InfoIconMasterParamIncrement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            InfoIconMasterParamIncrement.TabIndex = 21;
            InfoIconMasterParamIncrement.TabStop = false;
            toolTip1.SetToolTip(InfoIconMasterParamIncrement, resources.GetString("InfoIconMasterParamIncrement.ToolTip"));
            // 
            // InfoIconMasterExponent
            // 
            InfoIconMasterExponent.Image = (System.Drawing.Image)resources.GetObject("InfoIconMasterExponent.Image");
            InfoIconMasterExponent.Location = new System.Drawing.Point(411, 81);
            InfoIconMasterExponent.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            InfoIconMasterExponent.Name = "InfoIconMasterExponent";
            InfoIconMasterExponent.Size = new System.Drawing.Size(16, 16);
            InfoIconMasterExponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            InfoIconMasterExponent.TabIndex = 22;
            InfoIconMasterExponent.TabStop = false;
            toolTip1.SetToolTip(InfoIconMasterExponent, resources.GetString("InfoIconMasterExponent.ToolTip"));
            // 
            // InfoIconCustomExponents
            // 
            InfoIconCustomExponents.Image = (System.Drawing.Image)resources.GetObject("InfoIconCustomExponents.Image");
            InfoIconCustomExponents.Location = new System.Drawing.Point(628, 122);
            InfoIconCustomExponents.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            InfoIconCustomExponents.Name = "InfoIconCustomExponents";
            InfoIconCustomExponents.Size = new System.Drawing.Size(16, 16);
            InfoIconCustomExponents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            InfoIconCustomExponents.TabIndex = 23;
            InfoIconCustomExponents.TabStop = false;
            toolTip1.SetToolTip(InfoIconCustomExponents, resources.GetString("InfoIconCustomExponents.ToolTip"));
            // 
            // InfoIconDefaultExponents
            // 
            InfoIconDefaultExponents.Image = (System.Drawing.Image)resources.GetObject("InfoIconDefaultExponents.Image");
            InfoIconDefaultExponents.Location = new System.Drawing.Point(206, 160);
            InfoIconDefaultExponents.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            InfoIconDefaultExponents.Name = "InfoIconDefaultExponents";
            InfoIconDefaultExponents.Size = new System.Drawing.Size(16, 16);
            InfoIconDefaultExponents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            InfoIconDefaultExponents.TabIndex = 24;
            InfoIconDefaultExponents.TabStop = false;
            toolTip1.SetToolTip(InfoIconDefaultExponents, resources.GetString("InfoIconDefaultExponents.ToolTip"));
            // 
            // InfoIconLinearInterpolation
            // 
            InfoIconLinearInterpolation.Image = (System.Drawing.Image)resources.GetObject("InfoIconLinearInterpolation.Image");
            InfoIconLinearInterpolation.Location = new System.Drawing.Point(225, 43);
            InfoIconLinearInterpolation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            InfoIconLinearInterpolation.Name = "InfoIconLinearInterpolation";
            InfoIconLinearInterpolation.Size = new System.Drawing.Size(16, 16);
            InfoIconLinearInterpolation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            InfoIconLinearInterpolation.TabIndex = 25;
            InfoIconLinearInterpolation.TabStop = false;
            toolTip1.SetToolTip(InfoIconLinearInterpolation, resources.GetString("InfoIconLinearInterpolation.ToolTip"));
            // 
            // InfoIconCreateGif
            // 
            InfoIconCreateGif.Image = (System.Drawing.Image)resources.GetObject("InfoIconCreateGif.Image");
            InfoIconCreateGif.Location = new System.Drawing.Point(150, 119);
            InfoIconCreateGif.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            InfoIconCreateGif.Name = "InfoIconCreateGif";
            InfoIconCreateGif.Size = new System.Drawing.Size(16, 16);
            InfoIconCreateGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            InfoIconCreateGif.TabIndex = 26;
            InfoIconCreateGif.TabStop = false;
            toolTip1.SetToolTip(InfoIconCreateGif, resources.GetString("InfoIconCreateGif.ToolTip"));
            // 
            // infoIconUseSameDirectory
            // 
            infoIconUseSameDirectory.Image = (System.Drawing.Image)resources.GetObject("infoIconUseSameDirectory.Image");
            infoIconUseSameDirectory.Location = new System.Drawing.Point(285, 49);
            infoIconUseSameDirectory.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconUseSameDirectory.Name = "infoIconUseSameDirectory";
            infoIconUseSameDirectory.Size = new System.Drawing.Size(16, 16);
            infoIconUseSameDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconUseSameDirectory.TabIndex = 37;
            infoIconUseSameDirectory.TabStop = false;
            toolTip1.SetToolTip(infoIconUseSameDirectory, resources.GetString("infoIconUseSameDirectory.ToolTip"));
            // 
            // checkBoxAbsoluteModeMain
            // 
            checkBoxAbsoluteModeMain.AutoSize = true;
            checkBoxAbsoluteModeMain.Location = new System.Drawing.Point(246, 148);
            checkBoxAbsoluteModeMain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            checkBoxAbsoluteModeMain.Name = "checkBoxAbsoluteModeMain";
            checkBoxAbsoluteModeMain.Size = new System.Drawing.Size(161, 29);
            checkBoxAbsoluteModeMain.TabIndex = 46;
            checkBoxAbsoluteModeMain.Text = "Absolute Mode";
            toolTip1.SetToolTip(checkBoxAbsoluteModeMain, resources.GetString("checkBoxAbsoluteModeMain.ToolTip"));
            checkBoxAbsoluteModeMain.UseVisualStyleBackColor = true;
            checkBoxAbsoluteModeMain.CheckedChanged += checkBoxAbsoluteModeMain_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(267, 49);
            pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(16, 16);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            toolTip1.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // infoIconSingleThread
            // 
            infoIconSingleThread.Image = (System.Drawing.Image)resources.GetObject("infoIconSingleThread.Image");
            infoIconSingleThread.Location = new System.Drawing.Point(227, 89);
            infoIconSingleThread.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconSingleThread.Name = "infoIconSingleThread";
            infoIconSingleThread.Size = new System.Drawing.Size(16, 16);
            infoIconSingleThread.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconSingleThread.TabIndex = 56;
            infoIconSingleThread.TabStop = false;
            toolTip1.SetToolTip(infoIconSingleThread, resources.GetString("infoIconSingleThread.ToolTip"));
            // 
            // infoIconRemoveBlankFrames
            // 
            infoIconRemoveBlankFrames.Image = (System.Drawing.Image)resources.GetObject("infoIconRemoveBlankFrames.Image");
            infoIconRemoveBlankFrames.Location = new System.Drawing.Point(272, 154);
            infoIconRemoveBlankFrames.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconRemoveBlankFrames.Name = "infoIconRemoveBlankFrames";
            infoIconRemoveBlankFrames.Size = new System.Drawing.Size(16, 16);
            infoIconRemoveBlankFrames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconRemoveBlankFrames.TabIndex = 61;
            infoIconRemoveBlankFrames.TabStop = false;
            toolTip1.SetToolTip(infoIconRemoveBlankFrames, resources.GetString("infoIconRemoveBlankFrames.ToolTip"));
            // 
            // infoIconFilterSearch
            // 
            infoIconFilterSearch.Image = (System.Drawing.Image)resources.GetObject("infoIconFilterSearch.Image");
            infoIconFilterSearch.Location = new System.Drawing.Point(29, 754);
            infoIconFilterSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconFilterSearch.Name = "infoIconFilterSearch";
            infoIconFilterSearch.Size = new System.Drawing.Size(16, 16);
            infoIconFilterSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconFilterSearch.TabIndex = 62;
            infoIconFilterSearch.TabStop = false;
            toolTip1.SetToolTip(infoIconFilterSearch, resources.GetString("infoIconFilterSearch.ToolTip"));
            // 
            // infoIconAbsoluteModeMain
            // 
            infoIconAbsoluteModeMain.Image = (System.Drawing.Image)resources.GetObject("infoIconAbsoluteModeMain.Image");
            infoIconAbsoluteModeMain.Location = new System.Drawing.Point(402, 154);
            infoIconAbsoluteModeMain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconAbsoluteModeMain.Name = "infoIconAbsoluteModeMain";
            infoIconAbsoluteModeMain.Size = new System.Drawing.Size(16, 16);
            infoIconAbsoluteModeMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconAbsoluteModeMain.TabIndex = 63;
            infoIconAbsoluteModeMain.TabStop = false;
            toolTip1.SetToolTip(infoIconAbsoluteModeMain, resources.GetString("infoIconAbsoluteModeMain.ToolTip"));
            // 
            // btnShowParamNames
            // 
            btnShowParamNames.BackColor = System.Drawing.Color.SkyBlue;
            btnShowParamNames.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnShowParamNames.Location = new System.Drawing.Point(78, 33);
            btnShowParamNames.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnShowParamNames.Name = "btnShowParamNames";
            btnShowParamNames.Size = new System.Drawing.Size(283, 55);
            btnShowParamNames.TabIndex = 27;
            btnShowParamNames.Text = "Parameters";
            btnShowParamNames.UseVisualStyleBackColor = false;
            btnShowParamNames.Click += btnShowParamNames_Click;
            // 
            // labelTotalFrames
            // 
            labelTotalFrames.AutoSize = true;
            labelTotalFrames.Location = new System.Drawing.Point(19, 320);
            labelTotalFrames.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelTotalFrames.Name = "labelTotalFrames";
            labelTotalFrames.Size = new System.Drawing.Size(89, 25);
            labelTotalFrames.TabIndex = 29;
            labelTotalFrames.Text = "# Frames:";
            // 
            // TextLabelNearStartButton
            // 
            TextLabelNearStartButton.AutoSize = true;
            TextLabelNearStartButton.Location = new System.Drawing.Point(96, 705);
            TextLabelNearStartButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            TextLabelNearStartButton.Name = "TextLabelNearStartButton";
            TextLabelNearStartButton.Size = new System.Drawing.Size(60, 25);
            TextLabelNearStartButton.TabIndex = 30;
            TextLabelNearStartButton.Text = "Status";
            TextLabelNearStartButton.Visible = false;
            // 
            // labelMasterExponent
            // 
            labelMasterExponent.AutoSize = true;
            labelMasterExponent.Location = new System.Drawing.Point(279, 38);
            labelMasterExponent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelMasterExponent.Name = "labelMasterExponent";
            labelMasterExponent.Size = new System.Drawing.Size(85, 25);
            labelMasterExponent.TabIndex = 32;
            labelMasterExponent.Text = "InfoLabel";
            labelMasterExponent.Visible = false;
            // 
            // labelMasterParamName
            // 
            labelMasterParamName.AutoSize = true;
            labelMasterParamName.Location = new System.Drawing.Point(343, 270);
            labelMasterParamName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelMasterParamName.Name = "labelMasterParamName";
            labelMasterParamName.Size = new System.Drawing.Size(248, 25);
            labelMasterParamName.TabIndex = 33;
            labelMasterParamName.Text = "Master Parameter Name Label";
            // 
            // checkBoxUseSameOutputDir
            // 
            checkBoxUseSameOutputDir.AutoSize = true;
            checkBoxUseSameOutputDir.Location = new System.Drawing.Point(34, 42);
            checkBoxUseSameOutputDir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            checkBoxUseSameOutputDir.Name = "checkBoxUseSameOutputDir";
            checkBoxUseSameOutputDir.Size = new System.Drawing.Size(255, 29);
            checkBoxUseSameOutputDir.TabIndex = 34;
            checkBoxUseSameOutputDir.Text = "Use Same Output Directory";
            checkBoxUseSameOutputDir.UseVisualStyleBackColor = true;
            checkBoxUseSameOutputDir.CheckedChanged += checkBoxUseSameOutputDir_CheckedChanged;
            // 
            // btnSwapStartEndStrings
            // 
            btnSwapStartEndStrings.Location = new System.Drawing.Point(565, 172);
            btnSwapStartEndStrings.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnSwapStartEndStrings.Name = "btnSwapStartEndStrings";
            btnSwapStartEndStrings.Size = new System.Drawing.Size(94, 35);
            btnSwapStartEndStrings.TabIndex = 35;
            btnSwapStartEndStrings.Text = "Swap";
            btnSwapStartEndStrings.UseVisualStyleBackColor = true;
            btnSwapStartEndStrings.Click += btnSwapStartEndStrings_Click;
            // 
            // labelFFmpegNotFound
            // 
            labelFFmpegNotFound.AutoSize = true;
            labelFFmpegNotFound.ForeColor = System.Drawing.Color.Red;
            labelFFmpegNotFound.Location = new System.Drawing.Point(170, 115);
            labelFFmpegNotFound.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelFFmpegNotFound.Name = "labelFFmpegNotFound";
            labelFFmpegNotFound.Size = new System.Drawing.Size(265, 25);
            labelFFmpegNotFound.TabIndex = 36;
            labelFFmpegNotFound.Text = "(Unavailable: ffmpeg not found)";
            labelFFmpegNotFound.Visible = false;
            // 
            // checkBoxLogOnly
            // 
            checkBoxLogOnly.AutoSize = true;
            checkBoxLogOnly.Location = new System.Drawing.Point(34, 77);
            checkBoxLogOnly.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            checkBoxLogOnly.Name = "checkBoxLogOnly";
            checkBoxLogOnly.Size = new System.Drawing.Size(287, 29);
            checkBoxLogOnly.TabIndex = 38;
            checkBoxLogOnly.Text = "Don't Create Images (Log Only)";
            checkBoxLogOnly.UseVisualStyleBackColor = true;
            checkBoxLogOnly.CheckedChanged += checkBoxLogOnly_CheckedChanged;
            // 
            // radioNormalizeStartEnd
            // 
            radioNormalizeStartEnd.AutoSize = true;
            radioNormalizeStartEnd.Checked = true;
            radioNormalizeStartEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            radioNormalizeStartEnd.Location = new System.Drawing.Point(34, 38);
            radioNormalizeStartEnd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            radioNormalizeStartEnd.Name = "radioNormalizeStartEnd";
            radioNormalizeStartEnd.Size = new System.Drawing.Size(251, 29);
            radioNormalizeStartEnd.TabIndex = 40;
            radioNormalizeStartEnd.TabStop = true;
            radioNormalizeStartEnd.Text = "Normalize Within Start/End";
            radioNormalizeStartEnd.UseVisualStyleBackColor = true;
            radioNormalizeStartEnd.CheckedChanged += radioNormalizeStartEnd_CheckedChanged;
            // 
            // radioNormalizeMaxRanges
            // 
            radioNormalizeMaxRanges.AutoSize = true;
            radioNormalizeMaxRanges.Location = new System.Drawing.Point(34, 66);
            radioNormalizeMaxRanges.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            radioNormalizeMaxRanges.Name = "radioNormalizeMaxRanges";
            radioNormalizeMaxRanges.Size = new System.Drawing.Size(274, 29);
            radioNormalizeMaxRanges.TabIndex = 41;
            radioNormalizeMaxRanges.Text = "Normalize Within Max Ranges";
            radioNormalizeMaxRanges.UseVisualStyleBackColor = true;
            radioNormalizeMaxRanges.CheckedChanged += radioNormalizeMaxRanges_CheckedChanged;
            // 
            // radioNormalizeExtendedRanges
            // 
            radioNormalizeExtendedRanges.AutoSize = true;
            radioNormalizeExtendedRanges.Location = new System.Drawing.Point(34, 95);
            radioNormalizeExtendedRanges.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            radioNormalizeExtendedRanges.Name = "radioNormalizeExtendedRanges";
            radioNormalizeExtendedRanges.Size = new System.Drawing.Size(258, 29);
            radioNormalizeExtendedRanges.TabIndex = 42;
            radioNormalizeExtendedRanges.Text = "Normalize Extended Ranges";
            radioNormalizeExtendedRanges.UseVisualStyleBackColor = true;
            radioNormalizeExtendedRanges.CheckedChanged += radioNormalizeExtendedRanges_CheckedChanged;
            // 
            // radioNoNormalize
            // 
            radioNoNormalize.AutoSize = true;
            radioNoNormalize.Location = new System.Drawing.Point(34, 123);
            radioNoNormalize.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            radioNoNormalize.Name = "radioNoNormalize";
            radioNoNormalize.Size = new System.Drawing.Size(166, 29);
            radioNoNormalize.TabIndex = 43;
            radioNoNormalize.Text = "Don't Normalize";
            radioNoNormalize.UseVisualStyleBackColor = true;
            radioNoNormalize.CheckedChanged += radioNoNormalize_CheckedChanged;
            // 
            // groupBoxNormalizeRadios
            // 
            groupBoxNormalizeRadios.Controls.Add(infoIconAbsoluteModeMain);
            groupBoxNormalizeRadios.Controls.Add(checkBoxAbsoluteModeMain);
            groupBoxNormalizeRadios.Controls.Add(radioNormalizeStartEnd);
            groupBoxNormalizeRadios.Controls.Add(radioNoNormalize);
            groupBoxNormalizeRadios.Controls.Add(radioNormalizeMaxRanges);
            groupBoxNormalizeRadios.Controls.Add(radioNormalizeExtendedRanges);
            groupBoxNormalizeRadios.Enabled = false;
            groupBoxNormalizeRadios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBoxNormalizeRadios.Location = new System.Drawing.Point(723, 394);
            groupBoxNormalizeRadios.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            groupBoxNormalizeRadios.Name = "groupBoxNormalizeRadios";
            groupBoxNormalizeRadios.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            groupBoxNormalizeRadios.Size = new System.Drawing.Size(435, 192);
            groupBoxNormalizeRadios.TabIndex = 44;
            groupBoxNormalizeRadios.TabStop = false;
            groupBoxNormalizeRadios.Text = "Start/End Ranges";
            // 
            // btnShowExpressionForm
            // 
            btnShowExpressionForm.BackColor = System.Drawing.Color.LightCoral;
            btnShowExpressionForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnShowExpressionForm.Location = new System.Drawing.Point(78, 99);
            btnShowExpressionForm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnShowExpressionForm.Name = "btnShowExpressionForm";
            btnShowExpressionForm.Size = new System.Drawing.Size(283, 55);
            btnShowExpressionForm.TabIndex = 45;
            btnShowExpressionForm.Text = "Expressions";
            btnShowExpressionForm.UseVisualStyleBackColor = false;
            btnShowExpressionForm.Click += btnShowExpressionForm_Click;
            // 
            // btnLoadFilters
            // 
            btnLoadFilters.Location = new System.Drawing.Point(24, 787);
            btnLoadFilters.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnLoadFilters.Name = "btnLoadFilters";
            btnLoadFilters.Size = new System.Drawing.Size(141, 54);
            btnLoadFilters.TabIndex = 47;
            btnLoadFilters.Text = "Reload Filters";
            btnLoadFilters.UseCompatibleTextRendering = true;
            btnLoadFilters.UseVisualStyleBackColor = true;
            btnLoadFilters.Click += btnLoadFilters_Click;
            // 
            // txtSearchBoxMain
            // 
            txtSearchBoxMain.Location = new System.Drawing.Point(177, 746);
            txtSearchBoxMain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtSearchBoxMain.Name = "txtSearchBoxMain";
            txtSearchBoxMain.Size = new System.Drawing.Size(527, 31);
            txtSearchBoxMain.TabIndex = 48;
            txtSearchBoxMain.TextChanged += txtSearchBoxMain_TextChanged;
            // 
            // listBoxFiltersMain
            // 
            listBoxFiltersMain.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            listBoxFiltersMain.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            listBoxFiltersMain.FormattingEnabled = true;
            listBoxFiltersMain.Location = new System.Drawing.Point(177, 787);
            listBoxFiltersMain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            listBoxFiltersMain.Name = "listBoxFiltersMain";
            listBoxFiltersMain.Size = new System.Drawing.Size(527, 196);
            listBoxFiltersMain.TabIndex = 49;
            listBoxFiltersMain.SelectedIndexChanged += listBoxFiltersMain_SelectedIndexChanged;
            listBoxFiltersMain.DoubleClick += listBoxFiltersMain_DoubleClick;
            // 
            // labelFilterSearch
            // 
            labelFilterSearch.AutoSize = true;
            labelFilterSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelFilterSearch.Location = new System.Drawing.Point(47, 751);
            labelFilterSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelFilterSearch.Name = "labelFilterSearch";
            labelFilterSearch.Size = new System.Drawing.Size(126, 21);
            labelFilterSearch.TabIndex = 50;
            labelFilterSearch.Text = "Filters Search:";
            // 
            // dropdownDebugLog
            // 
            dropdownDebugLog.FormattingEnabled = true;
            dropdownDebugLog.Items.AddRange(new object[] { "None", "Verbose 1", "Verbose 2", "Verbose 3", "Debug" });
            dropdownDebugLog.Location = new System.Drawing.Point(139, 40);
            dropdownDebugLog.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            dropdownDebugLog.Name = "dropdownDebugLog";
            dropdownDebugLog.Size = new System.Drawing.Size(123, 33);
            dropdownDebugLog.TabIndex = 52;
            // 
            // labelDebugLog
            // 
            labelDebugLog.AutoSize = true;
            labelDebugLog.Location = new System.Drawing.Point(29, 43);
            labelDebugLog.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelDebugLog.Name = "labelDebugLog";
            labelDebugLog.Size = new System.Drawing.Size(105, 25);
            labelDebugLog.TabIndex = 53;
            labelDebugLog.Text = "Debug Log:";
            // 
            // checkBoxSingleThreadMode
            // 
            checkBoxSingleThreadMode.AutoSize = true;
            checkBoxSingleThreadMode.Location = new System.Drawing.Point(34, 83);
            checkBoxSingleThreadMode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            checkBoxSingleThreadMode.Name = "checkBoxSingleThreadMode";
            checkBoxSingleThreadMode.Size = new System.Drawing.Size(197, 29);
            checkBoxSingleThreadMode.TabIndex = 55;
            checkBoxSingleThreadMode.Text = "Single Thread Mode";
            checkBoxSingleThreadMode.UseVisualStyleBackColor = true;
            // 
            // toolStripActiveFilterLabel
            // 
            toolStripActiveFilterLabel.Name = "toolStripActiveFilterLabel";
            toolStripActiveFilterLabel.Size = new System.Drawing.Size(169, 25);
            toolStripActiveFilterLabel.Text = "toolStripStatusLabel";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripActiveFilterLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 998);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            statusStrip1.Size = new System.Drawing.Size(1179, 32);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 57;
            statusStrip1.Text = "statusStrip1";
            // 
            // progressBarGeneration
            // 
            progressBarGeneration.Location = new System.Drawing.Point(100, 677);
            progressBarGeneration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            progressBarGeneration.Name = "progressBarGeneration";
            progressBarGeneration.Size = new System.Drawing.Size(289, 23);
            progressBarGeneration.TabIndex = 58;
            // 
            // btnGifTools
            // 
            btnGifTools.Location = new System.Drawing.Point(78, 169);
            btnGifTools.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnGifTools.Name = "btnGifTools";
            btnGifTools.Size = new System.Drawing.Size(285, 55);
            btnGifTools.TabIndex = 59;
            btnGifTools.Text = "GIF Tools";
            btnGifTools.UseCompatibleTextRendering = true;
            btnGifTools.UseVisualStyleBackColor = true;
            btnGifTools.Click += btnGifTools_Click;
            // 
            // checkBoxRemoveBlankFrames
            // 
            checkBoxRemoveBlankFrames.AutoSize = true;
            checkBoxRemoveBlankFrames.Checked = true;
            checkBoxRemoveBlankFrames.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxRemoveBlankFrames.Location = new System.Drawing.Point(33, 147);
            checkBoxRemoveBlankFrames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            checkBoxRemoveBlankFrames.Name = "checkBoxRemoveBlankFrames";
            checkBoxRemoveBlankFrames.Size = new System.Drawing.Size(242, 29);
            checkBoxRemoveBlankFrames.TabIndex = 60;
            checkBoxRemoveBlankFrames.Text = "Remove Blank GIF Frames";
            checkBoxRemoveBlankFrames.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptions
            // 
            groupBoxOptions.Controls.Add(infoIconUseSameDirectory);
            groupBoxOptions.Controls.Add(InfoIconCreateGif);
            groupBoxOptions.Controls.Add(checkBoxUseSameOutputDir);
            groupBoxOptions.Controls.Add(chkCreateGif);
            groupBoxOptions.Controls.Add(infoIconRemoveBlankFrames);
            groupBoxOptions.Controls.Add(checkBoxRemoveBlankFrames);
            groupBoxOptions.Controls.Add(labelFFmpegNotFound);
            groupBoxOptions.Controls.Add(checkBoxLogOnly);
            groupBoxOptions.Location = new System.Drawing.Point(723, 35);
            groupBoxOptions.Name = "groupBoxOptions";
            groupBoxOptions.Size = new System.Drawing.Size(439, 200);
            groupBoxOptions.TabIndex = 63;
            groupBoxOptions.TabStop = false;
            groupBoxOptions.Text = "Output Options";
            // 
            // groupBoxAdvancedOptions
            // 
            groupBoxAdvancedOptions.Controls.Add(infoIconSingleThread);
            groupBoxAdvancedOptions.Controls.Add(labelDebugLog);
            groupBoxAdvancedOptions.Controls.Add(dropdownDebugLog);
            groupBoxAdvancedOptions.Controls.Add(pictureBox1);
            groupBoxAdvancedOptions.Controls.Add(checkBoxSingleThreadMode);
            groupBoxAdvancedOptions.Location = new System.Drawing.Point(723, 250);
            groupBoxAdvancedOptions.Name = "groupBoxAdvancedOptions";
            groupBoxAdvancedOptions.Size = new System.Drawing.Size(435, 136);
            groupBoxAdvancedOptions.TabIndex = 64;
            groupBoxAdvancedOptions.TabStop = false;
            groupBoxAdvancedOptions.Text = "Advanced Options";
            // 
            // groupBoxTools
            // 
            groupBoxTools.Controls.Add(btnGifTools);
            groupBoxTools.Controls.Add(btnShowParamNames);
            groupBoxTools.Controls.Add(btnShowExpressionForm);
            groupBoxTools.Location = new System.Drawing.Point(727, 740);
            groupBoxTools.Name = "groupBoxTools";
            groupBoxTools.Size = new System.Drawing.Size(435, 243);
            groupBoxTools.TabIndex = 65;
            groupBoxTools.TabStop = false;
            groupBoxTools.Text = "Tools";
            // 
            // groupBoxInterpolation
            // 
            groupBoxInterpolation.Controls.Add(InfoIconDefaultExponents);
            groupBoxInterpolation.Controls.Add(InfoIconLinearInterpolation);
            groupBoxInterpolation.Controls.Add(rbNoExponents);
            groupBoxInterpolation.Controls.Add(txtMasterExponent);
            groupBoxInterpolation.Controls.Add(txtExponentArray);
            groupBoxInterpolation.Controls.Add(rbMasterExponent);
            groupBoxInterpolation.Controls.Add(rbDefaultExponents);
            groupBoxInterpolation.Controls.Add(rbCustomExponents);
            groupBoxInterpolation.Controls.Add(InfoIconMasterExponent);
            groupBoxInterpolation.Controls.Add(InfoIconCustomExponents);
            groupBoxInterpolation.Controls.Add(labelMasterExponent);
            groupBoxInterpolation.Location = new System.Drawing.Point(25, 394);
            groupBoxInterpolation.Name = "groupBoxInterpolation";
            groupBoxInterpolation.Size = new System.Drawing.Size(664, 197);
            groupBoxInterpolation.TabIndex = 66;
            groupBoxInterpolation.TabStop = false;
            groupBoxInterpolation.Text = "Interolation Modes";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1179, 1030);
            Controls.Add(groupBoxTools);
            Controls.Add(groupBoxAdvancedOptions);
            Controls.Add(groupBoxOptions);
            Controls.Add(infoIconFilterSearch);
            Controls.Add(progressBarGeneration);
            Controls.Add(statusStrip1);
            Controls.Add(labelFilterSearch);
            Controls.Add(listBoxFiltersMain);
            Controls.Add(txtSearchBoxMain);
            Controls.Add(btnLoadFilters);
            Controls.Add(btnSwapStartEndStrings);
            Controls.Add(labelMasterParamName);
            Controls.Add(TextLabelNearStartButton);
            Controls.Add(labelTotalFrames);
            Controls.Add(nudTotalFrames);
            Controls.Add(InfoIconMasterParamIncrement);
            Controls.Add(InfoIconMasterParamIndex);
            Controls.Add(btnViewOutputDirectory);
            Controls.Add(btnStart);
            Controls.Add(nudMasterParamIncrement);
            Controls.Add(lblMasterParamIncrement);
            Controls.Add(nudMasterParamIndex);
            Controls.Add(lblMasterParamIndex);
            Controls.Add(txtEndParams);
            Controls.Add(lblEndParams);
            Controls.Add(txtStartParams);
            Controls.Add(lblStartParams);
            Controls.Add(btnSelectInputFile);
            Controls.Add(txtInputFilePath);
            Controls.Add(lblInputFile);
            Controls.Add(btnCancel);
            Controls.Add(groupBoxNormalizeRadios);
            Controls.Add(groupBoxInterpolation);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "G'MIC Animator";
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            ((System.ComponentModel.ISupportInitialize)nudTotalFrames).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMasterParamIncrement).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMasterParamIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconMasterParamIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconMasterParamIncrement).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconMasterExponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconCustomExponents).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconDefaultExponents).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconLinearInterpolation).EndInit();
            ((System.ComponentModel.ISupportInitialize)InfoIconCreateGif).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconUseSameDirectory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconSingleThread).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconRemoveBlankFrames).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconFilterSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconAbsoluteModeMain).EndInit();
            groupBoxNormalizeRadios.ResumeLayout(false);
            groupBoxNormalizeRadios.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBoxOptions.ResumeLayout(false);
            groupBoxOptions.PerformLayout();
            groupBoxAdvancedOptions.ResumeLayout(false);
            groupBoxAdvancedOptions.PerformLayout();
            groupBoxTools.ResumeLayout(false);
            groupBoxInterpolation.ResumeLayout(false);
            groupBoxInterpolation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.Button btnSelectInputFile;
        private System.Windows.Forms.Label lblStartParams;
        private System.Windows.Forms.TextBox txtStartParams;
        private System.Windows.Forms.Label lblEndParams;
        private System.Windows.Forms.TextBox txtEndParams;
        private System.Windows.Forms.Label lblMasterParamIndex;
        private System.Windows.Forms.NumericUpDown nudMasterParamIndex;
        private System.Windows.Forms.Label lblMasterParamIncrement;
        //private System.Windows.Forms.NumericUpDown nudMasterParamIncrement;
        private System.Windows.Forms.TextBox txtMasterExponent;
        private System.Windows.Forms.TextBox txtExponentArray;
        private System.Windows.Forms.CheckBox chkCreateGif;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnViewOutputDirectory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbNoExponents;
        private System.Windows.Forms.RadioButton rbMasterExponent;
        private System.Windows.Forms.RadioButton rbDefaultExponents;
        private System.Windows.Forms.RadioButton rbCustomExponents;
        private System.Windows.Forms.PictureBox InfoIconMasterParamIndex;
        private System.Windows.Forms.PictureBox InfoIconMasterParamIncrement;
        private System.Windows.Forms.PictureBox InfoIconMasterExponent;
        private System.Windows.Forms.PictureBox InfoIconCustomExponents;
        private System.Windows.Forms.PictureBox InfoIconDefaultExponents;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox InfoIconLinearInterpolation;
        private System.Windows.Forms.PictureBox InfoIconCreateGif;
        private System.Windows.Forms.Button btnShowParamNames;
        //private System.Windows.Forms.NumericUpDown nudTotalFrames;
        private System.Windows.Forms.Label labelTotalFrames;
        private System.Windows.Forms.Label TextLabelNearStartButton;
        private InvisibleNumericUpDown nudTotalFrames;
        private InvisibleNumericUpDown nudMasterParamIncrement;
        private System.Windows.Forms.Label labelMasterExponent;
        private System.Windows.Forms.Label labelMasterParamName;
        private System.Windows.Forms.CheckBox checkBoxUseSameOutputDir;
        private System.Windows.Forms.Button btnSwapStartEndStrings;
        private System.Windows.Forms.Label labelFFmpegNotFound;
        private System.Windows.Forms.PictureBox infoIconUseSameDirectory;
        private System.Windows.Forms.CheckBox checkBoxLogOnly;
        private System.Windows.Forms.RadioButton radioNormalizeStartEnd;
        private System.Windows.Forms.RadioButton radioNormalizeMaxRanges;
        private System.Windows.Forms.RadioButton radioNormalizeExtendedRanges;
        private System.Windows.Forms.RadioButton radioNoNormalize;
        private System.Windows.Forms.GroupBox groupBoxNormalizeRadios;
        private System.Windows.Forms.Button btnShowExpressionForm;
        private System.Windows.Forms.CheckBox checkBoxAbsoluteModeMain;
        private System.Windows.Forms.Button btnLoadFilters;
        private System.Windows.Forms.TextBox txtSearchBoxMain;
        private System.Windows.Forms.ListBox listBoxFiltersMain;
        private System.Windows.Forms.Label labelFilterSearch;
        private System.Windows.Forms.ComboBox dropdownDebugLog;
        private System.Windows.Forms.Label labelDebugLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxSingleThreadMode;
        private System.Windows.Forms.PictureBox infoIconSingleThread;
        private System.Windows.Forms.ToolStripStatusLabel toolStripActiveFilterLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ProgressBar progressBarGeneration;
        private System.Windows.Forms.Button btnGifTools;
        private System.Windows.Forms.CheckBox checkBoxRemoveBlankFrames;
        private System.Windows.Forms.PictureBox infoIconRemoveBlankFrames;
        private System.Windows.Forms.PictureBox infoIconFilterSearch;
        private System.Windows.Forms.PictureBox infoIconAbsoluteModeMain;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.GroupBox groupBoxAdvancedOptions;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.GroupBox groupBoxInterpolation;
    }
}