using System.Drawing;

namespace GmicAnimate
{
    partial class ExpressionsForm
    {
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

        private void InitalizatManualComponents()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(chartCurve)).BeginInit();
            // 
            // chartCurve
            // 
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            chartArea1.Name = "ChartArea1";
            this.chartCurve.ChartAreas.Add(chartArea1);
            this.chartCurve.Location = new System.Drawing.Point(CompensateDPI(410), CompensateDPI(78));
            this.chartCurve.Name = "chartCurve";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "ValueSeries";
            this.chartCurve.Series.Add(series1);

            // Add series to use as comparison
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.MarkerSize = 6;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series2.Name = "CompareSeries";
            series2.Color = Color.DarkViolet;
            series2.BorderWidth = CompensateDPI(2);
            this.chartCurve.Series.Add(series2);

            this.chartCurve.Size = new System.Drawing.Size(CompensateDPI(560), CompensateDPI(300));
            this.chartCurve.TabIndex = 7;
            this.chartCurve.Text = "Values vs Frames Chart";

            // Set chart info - title, min axis, etc
            chartCurve.ChartAreas[0].AxisX.Minimum = 0;
            chartCurve.ChartAreas[0].AxisX.Title = "Frame Numbers";
            chartCurve.ChartAreas[0].AxisY.Title = "Interpolated Parameter Values";

            Controls.Add(chartCurve);

            ((System.ComponentModel.ISupportInitialize)(chartCurve)).EndInit();
        }



        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpressionsForm));
            dataGridViewExpressions = new System.Windows.Forms.DataGridView();
            labelCurrentExpressionString = new System.Windows.Forms.Label();
            txtCurrentExpressionParamString = new System.Windows.Forms.TextBox();
            btnSendExpressionsStringToMainWindow = new System.Windows.Forms.Button();
            btnTestChart = new System.Windows.Forms.Button();
            btnChartValues = new System.Windows.Forms.Button();
            checkBoxKeepFramesConstant = new System.Windows.Forms.CheckBox();
            nudGraphConstantFrameCount = new System.Windows.Forms.NumericUpDown();
            checkBoxAutoUpdateGraph = new System.Windows.Forms.CheckBox();
            nudMasterParamIndexClone = new System.Windows.Forms.NumericUpDown();
            labelMasterIndexClone = new System.Windows.Forms.Label();
            labelNoGraphToggleParam = new System.Windows.Forms.Label();
            btnHelpExpressionsForm = new System.Windows.Forms.Button();
            labelExampleExpressionButtons = new System.Windows.Forms.Label();
            btnExampleCosine = new System.Windows.Forms.Button();
            labelErrorWhileGraphing = new System.Windows.Forms.Label();
            groupBoxNormalizeRadiosClone = new System.Windows.Forms.GroupBox();
            radioNormalizeStartEndClone = new System.Windows.Forms.RadioButton();
            radioNoNormalizeClone = new System.Windows.Forms.RadioButton();
            radioNormalizeMaxRangesClone = new System.Windows.Forms.RadioButton();
            radioNormalizeExtendedRangesClone = new System.Windows.Forms.RadioButton();
            checkBoxAbsoluteMode = new System.Windows.Forms.CheckBox();
            toolTipExpressionsForm = new System.Windows.Forms.ToolTip(components);
            infoIconCopyAnimated = new System.Windows.Forms.PictureBox();
            infoIconModeChangesCheckbox = new System.Windows.Forms.PictureBox();
            infoIconImperfectLoops = new System.Windows.Forms.PictureBox();
            infoIconAbsoluteModeExpressions = new System.Windows.Forms.PictureBox();
            btnApplyToChecked = new System.Windows.Forms.Button();
            btnApplyToAnimated = new System.Windows.Forms.Button();
            btnUncheckAll = new System.Windows.Forms.Button();
            btnResetExpressions = new System.Windows.Forms.Button();
            btnCheckAll = new System.Windows.Forms.Button();
            btnExampleExp = new System.Windows.Forms.Button();
            btnExampleSine = new System.Windows.Forms.Button();
            dropdownExamplesNonLoops = new System.Windows.Forms.ComboBox();
            labelExamplesNonLoops = new System.Windows.Forms.Label();
            dropdownExampleLoops = new System.Windows.Forms.ComboBox();
            labelExamplesPerfectLoops = new System.Windows.Forms.Label();
            labelReplacingXWithT = new System.Windows.Forms.Label();
            labelExamplesImperfectLoops = new System.Windows.Forms.Label();
            dropdownExamplesImperfectLoops = new System.Windows.Forms.ComboBox();
            btnCompareSave = new System.Windows.Forms.Button();
            btnResetCompare = new System.Windows.Forms.Button();
            checkBoxCompareUpdateNormalization = new System.Windows.Forms.CheckBox();
            btnShowFunctionInfo = new System.Windows.Forms.Button();
            txtComparedExpression = new System.Windows.Forms.TextBox();
            labelComparisonExpressionTextBox = new System.Windows.Forms.Label();
            checkBoxAutoUpdateMainWindow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpressions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGraphConstantFrameCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMasterParamIndexClone).BeginInit();
            groupBoxNormalizeRadiosClone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoIconCopyAnimated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconModeChangesCheckbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconImperfectLoops).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoIconAbsoluteModeExpressions).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewExpressions
            // 
            dataGridViewExpressions.AllowUserToAddRows = false;
            dataGridViewExpressions.AllowUserToDeleteRows = false;
            dataGridViewExpressions.AllowUserToResizeRows = false;
            dataGridViewExpressions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewExpressions.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewExpressions.Location = new Point(14, 20);
            dataGridViewExpressions.Name = "dataGridViewExpressions";
            dataGridViewExpressions.RowHeadersWidth = 62;
            dataGridViewExpressions.RowTemplate.Height = 20;
            dataGridViewExpressions.Size = new Size(579, 1066);
            dataGridViewExpressions.TabIndex = 0;
            dataGridViewExpressions.CellBeginEdit += dataGridViewExpressions_CellBeginEdit;
            dataGridViewExpressions.CellClick += dataGridViewExpressions_CellClick_1;
            dataGridViewExpressions.CellEndEdit += dataGridViewExpressions_CellEndEdit_1;
            dataGridViewExpressions.CellValueChanged += dataGridViewExpressions_CellValueChanged;
            // 
            // labelCurrentExpressionString
            // 
            labelCurrentExpressionString.AutoSize = true;
            labelCurrentExpressionString.Location = new Point(20, 1112);
            labelCurrentExpressionString.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelCurrentExpressionString.Name = "labelCurrentExpressionString";
            labelCurrentExpressionString.Size = new Size(343, 25);
            labelCurrentExpressionString.TabIndex = 5;
            labelCurrentExpressionString.Text = "Current String of Exponents / Expressions:";
            // 
            // txtCurrentExpressionParamString
            // 
            txtCurrentExpressionParamString.Location = new Point(20, 1142);
            txtCurrentExpressionParamString.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            txtCurrentExpressionParamString.Name = "txtCurrentExpressionParamString";
            txtCurrentExpressionParamString.ReadOnly = true;
            txtCurrentExpressionParamString.Size = new Size(571, 31);
            txtCurrentExpressionParamString.TabIndex = 4;
            // 
            // btnSendExpressionsStringToMainWindow
            // 
            btnSendExpressionsStringToMainWindow.BackColor = Color.LightGreen;
            btnSendExpressionsStringToMainWindow.Location = new Point(20, 1205);
            btnSendExpressionsStringToMainWindow.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnSendExpressionsStringToMainWindow.Name = "btnSendExpressionsStringToMainWindow";
            btnSendExpressionsStringToMainWindow.Size = new Size(181, 45);
            btnSendExpressionsStringToMainWindow.TabIndex = 6;
            btnSendExpressionsStringToMainWindow.Text = "Use Above Values";
            btnSendExpressionsStringToMainWindow.UseVisualStyleBackColor = false;
            btnSendExpressionsStringToMainWindow.Click += btnSendExpressionsStringToMainWindow_Click;
            // 
            // btnTestChart
            // 
            btnTestChart.Location = new Point(19, 1260);
            btnTestChart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnTestChart.Name = "btnTestChart";
            btnTestChart.Size = new Size(126, 45);
            btnTestChart.TabIndex = 8;
            btnTestChart.Text = "Test";
            btnTestChart.UseVisualStyleBackColor = true;
            btnTestChart.Visible = false;
            btnTestChart.Click += btnTestChart_Click;
            // 
            // btnChartValues
            // 
            btnChartValues.Location = new Point(619, 584);
            btnChartValues.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnChartValues.Name = "btnChartValues";
            btnChartValues.Size = new Size(320, 64);
            btnChartValues.TabIndex = 9;
            btnChartValues.Text = "Graph Preview of Parameter Values (Manually Refresh)\r\n\r\n";
            btnChartValues.UseVisualStyleBackColor = true;
            btnChartValues.Click += btnChartValues_Click;
            // 
            // checkBoxKeepFramesConstant
            // 
            checkBoxKeepFramesConstant.AutoSize = true;
            checkBoxKeepFramesConstant.Location = new Point(956, 738);
            checkBoxKeepFramesConstant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            checkBoxKeepFramesConstant.Name = "checkBoxKeepFramesConstant";
            checkBoxKeepFramesConstant.Size = new Size(323, 29);
            checkBoxKeepFramesConstant.TabIndex = 10;
            checkBoxKeepFramesConstant.Text = "Preview With Constant Frame Count";
            checkBoxKeepFramesConstant.UseVisualStyleBackColor = true;
            checkBoxKeepFramesConstant.CheckedChanged += checkBoxKeepFramesConstant_CheckedChanged;
            // 
            // nudGraphConstantFrameCount
            // 
            nudGraphConstantFrameCount.Enabled = false;
            nudGraphConstantFrameCount.Font = new Font("Microsoft Sans Serif", 10F);
            nudGraphConstantFrameCount.Location = new Point(1280, 737);
            nudGraphConstantFrameCount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nudGraphConstantFrameCount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudGraphConstantFrameCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGraphConstantFrameCount.Name = "nudGraphConstantFrameCount";
            nudGraphConstantFrameCount.Size = new Size(120, 30);
            nudGraphConstantFrameCount.TabIndex = 11;
            nudGraphConstantFrameCount.Value = new decimal(new int[] { 100, 0, 0, 0 });
            nudGraphConstantFrameCount.ValueChanged += nudGraphConstantFrameCount_ValueChanged;
            // 
            // checkBoxAutoUpdateGraph
            // 
            checkBoxAutoUpdateGraph.AutoSize = true;
            checkBoxAutoUpdateGraph.Checked = true;
            checkBoxAutoUpdateGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAutoUpdateGraph.Location = new Point(956, 774);
            checkBoxAutoUpdateGraph.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            checkBoxAutoUpdateGraph.Name = "checkBoxAutoUpdateGraph";
            checkBoxAutoUpdateGraph.Size = new Size(193, 29);
            checkBoxAutoUpdateGraph.TabIndex = 12;
            checkBoxAutoUpdateGraph.Text = "Auto Update Graph";
            checkBoxAutoUpdateGraph.UseVisualStyleBackColor = true;
            checkBoxAutoUpdateGraph.CheckedChanged += checkBoxAutoUpdateGraph_CheckedChanged;
            // 
            // nudMasterParamIndexClone
            // 
            nudMasterParamIndexClone.Font = new Font("Microsoft Sans Serif", 12F);
            nudMasterParamIndexClone.Location = new Point(619, 52);
            nudMasterParamIndexClone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nudMasterParamIndexClone.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nudMasterParamIndexClone.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMasterParamIndexClone.Name = "nudMasterParamIndexClone";
            nudMasterParamIndexClone.Size = new Size(83, 35);
            nudMasterParamIndexClone.TabIndex = 13;
            nudMasterParamIndexClone.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudMasterParamIndexClone.ValueChanged += nudMasterParamIndexClone_ValueChanged;
            // 
            // labelMasterIndexClone
            // 
            labelMasterIndexClone.AutoSize = true;
            labelMasterIndexClone.Location = new Point(613, 22);
            labelMasterIndexClone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelMasterIndexClone.Name = "labelMasterIndexClone";
            labelMasterIndexClone.Size = new Size(95, 25);
            labelMasterIndexClone.TabIndex = 14;
            labelMasterIndexClone.Text = "Parameter:";
            // 
            // labelNoGraphToggleParam
            // 
            labelNoGraphToggleParam.AutoSize = true;
            labelNoGraphToggleParam.BackColor = SystemColors.Window;
            labelNoGraphToggleParam.Font = new Font("Microsoft Sans Serif", 10F);
            labelNoGraphToggleParam.Location = new Point(759, 285);
            labelNoGraphToggleParam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelNoGraphToggleParam.Name = "labelNoGraphToggleParam";
            labelNoGraphToggleParam.Size = new Size(501, 25);
            labelNoGraphToggleParam.TabIndex = 15;
            labelNoGraphToggleParam.Text = "Graph Not Applicable - Parameter type can't be graphed.\r\n";
            labelNoGraphToggleParam.Visible = false;
            // 
            // btnHelpExpressionsForm
            // 
            btnHelpExpressionsForm.Location = new Point(1319, 1247);
            btnHelpExpressionsForm.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnHelpExpressionsForm.Name = "btnHelpExpressionsForm";
            btnHelpExpressionsForm.Size = new Size(151, 53);
            btnHelpExpressionsForm.TabIndex = 16;
            btnHelpExpressionsForm.Text = "Help";
            btnHelpExpressionsForm.UseVisualStyleBackColor = true;
            btnHelpExpressionsForm.Click += btnHelpExpressionsForm_Click;
            // 
            // labelExampleExpressionButtons
            // 
            labelExampleExpressionButtons.AutoSize = true;
            labelExampleExpressionButtons.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelExampleExpressionButtons.Location = new Point(909, 861);
            labelExampleExpressionButtons.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelExampleExpressionButtons.Name = "labelExampleExpressionButtons";
            labelExampleExpressionButtons.Size = new Size(289, 32);
            labelExampleExpressionButtons.TabIndex = 18;
            labelExampleExpressionButtons.Text = "Example Expressions:";
            // 
            // btnExampleCosine
            // 
            btnExampleCosine.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExampleCosine.Location = new Point(898, 1092);
            btnExampleCosine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnExampleCosine.Name = "btnExampleCosine";
            btnExampleCosine.Size = new Size(264, 75);
            btnExampleCosine.TabIndex = 19;
            btnExampleCosine.Text = "cos(2*pi*t)";
            btnExampleCosine.UseVisualStyleBackColor = true;
            btnExampleCosine.Click += btnExampleCosine_Click;
            // 
            // labelErrorWhileGraphing
            // 
            labelErrorWhileGraphing.AutoSize = true;
            labelErrorWhileGraphing.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErrorWhileGraphing.ForeColor = Color.Red;
            labelErrorWhileGraphing.Location = new Point(743, 98);
            labelErrorWhileGraphing.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelErrorWhileGraphing.Name = "labelErrorWhileGraphing";
            labelErrorWhileGraphing.Size = new Size(544, 22);
            labelErrorWhileGraphing.TabIndex = 20;
            labelErrorWhileGraphing.Text = "Error While Graphing: Click graph preview button for details";
            labelErrorWhileGraphing.Visible = false;
            // 
            // groupBoxNormalizeRadiosClone
            // 
            groupBoxNormalizeRadiosClone.Controls.Add(radioNormalizeStartEndClone);
            groupBoxNormalizeRadiosClone.Controls.Add(radioNoNormalizeClone);
            groupBoxNormalizeRadiosClone.Controls.Add(radioNormalizeMaxRangesClone);
            groupBoxNormalizeRadiosClone.Controls.Add(radioNormalizeExtendedRangesClone);
            groupBoxNormalizeRadiosClone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            groupBoxNormalizeRadiosClone.Location = new Point(619, 669);
            groupBoxNormalizeRadiosClone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            groupBoxNormalizeRadiosClone.Name = "groupBoxNormalizeRadiosClone";
            groupBoxNormalizeRadiosClone.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            groupBoxNormalizeRadiosClone.Size = new Size(297, 143);
            groupBoxNormalizeRadiosClone.TabIndex = 45;
            groupBoxNormalizeRadiosClone.TabStop = false;
            // 
            // radioNormalizeStartEndClone
            // 
            radioNormalizeStartEndClone.AutoSize = true;
            radioNormalizeStartEndClone.Checked = true;
            radioNormalizeStartEndClone.ForeColor = SystemColors.ControlText;
            radioNormalizeStartEndClone.Location = new Point(10, 20);
            radioNormalizeStartEndClone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            radioNormalizeStartEndClone.Name = "radioNormalizeStartEndClone";
            radioNormalizeStartEndClone.Size = new Size(251, 29);
            radioNormalizeStartEndClone.TabIndex = 40;
            radioNormalizeStartEndClone.TabStop = true;
            radioNormalizeStartEndClone.Text = "Normalize Within Start/End";
            radioNormalizeStartEndClone.UseVisualStyleBackColor = true;
            radioNormalizeStartEndClone.CheckedChanged += radioNormalizeStartEndClone_CheckedChanged;
            // 
            // radioNoNormalizeClone
            // 
            radioNoNormalizeClone.AutoSize = true;
            radioNoNormalizeClone.Location = new Point(10, 105);
            radioNoNormalizeClone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            radioNoNormalizeClone.Name = "radioNoNormalizeClone";
            radioNoNormalizeClone.Size = new Size(166, 29);
            radioNoNormalizeClone.TabIndex = 43;
            radioNoNormalizeClone.Text = "Don't Normalize";
            radioNoNormalizeClone.UseVisualStyleBackColor = true;
            radioNoNormalizeClone.CheckedChanged += radioNoNormalizeClone_CheckedChanged;
            // 
            // radioNormalizeMaxRangesClone
            // 
            radioNormalizeMaxRangesClone.AutoSize = true;
            radioNormalizeMaxRangesClone.Location = new Point(10, 48);
            radioNormalizeMaxRangesClone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            radioNormalizeMaxRangesClone.Name = "radioNormalizeMaxRangesClone";
            radioNormalizeMaxRangesClone.Size = new Size(274, 29);
            radioNormalizeMaxRangesClone.TabIndex = 41;
            radioNormalizeMaxRangesClone.Text = "Normalize Within Max Ranges";
            radioNormalizeMaxRangesClone.UseVisualStyleBackColor = true;
            radioNormalizeMaxRangesClone.CheckedChanged += radioNormalizeMaxRangesClone_CheckedChanged;
            // 
            // radioNormalizeExtendedRangesClone
            // 
            radioNormalizeExtendedRangesClone.AutoSize = true;
            radioNormalizeExtendedRangesClone.Location = new Point(10, 77);
            radioNormalizeExtendedRangesClone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            radioNormalizeExtendedRangesClone.Name = "radioNormalizeExtendedRangesClone";
            radioNormalizeExtendedRangesClone.Size = new Size(258, 29);
            radioNormalizeExtendedRangesClone.TabIndex = 42;
            radioNormalizeExtendedRangesClone.Text = "Normalize Extended Ranges";
            radioNormalizeExtendedRangesClone.UseVisualStyleBackColor = true;
            radioNormalizeExtendedRangesClone.CheckedChanged += radioNormalizeExtendedRangesClone_CheckedChanged;
            // 
            // checkBoxAbsoluteMode
            // 
            checkBoxAbsoluteMode.AutoSize = true;
            checkBoxAbsoluteMode.Location = new Point(629, 816);
            checkBoxAbsoluteMode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            checkBoxAbsoluteMode.Name = "checkBoxAbsoluteMode";
            checkBoxAbsoluteMode.Size = new Size(161, 29);
            checkBoxAbsoluteMode.TabIndex = 46;
            checkBoxAbsoluteMode.Text = "Absolute Mode";
            toolTipExpressionsForm.SetToolTip(checkBoxAbsoluteMode, resources.GetString("checkBoxAbsoluteMode.ToolTip"));
            checkBoxAbsoluteMode.UseVisualStyleBackColor = true;
            checkBoxAbsoluteMode.CheckedChanged += checkBoxAbsoluteMode_CheckedChanged;
            // 
            // infoIconCopyAnimated
            // 
            infoIconCopyAnimated.Image = (Image)resources.GetObject("infoIconCopyAnimated.Image");
            infoIconCopyAnimated.Location = new Point(432, 1270);
            infoIconCopyAnimated.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconCopyAnimated.Name = "infoIconCopyAnimated";
            infoIconCopyAnimated.Size = new Size(16, 16);
            infoIconCopyAnimated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconCopyAnimated.TabIndex = 55;
            infoIconCopyAnimated.TabStop = false;
            toolTipExpressionsForm.SetToolTip(infoIconCopyAnimated, resources.GetString("infoIconCopyAnimated.ToolTip"));
            // 
            // infoIconModeChangesCheckbox
            // 
            infoIconModeChangesCheckbox.Image = (Image)resources.GetObject("infoIconModeChangesCheckbox.Image");
            infoIconModeChangesCheckbox.Location = new Point(1418, 640);
            infoIconModeChangesCheckbox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconModeChangesCheckbox.Name = "infoIconModeChangesCheckbox";
            infoIconModeChangesCheckbox.Size = new Size(16, 16);
            infoIconModeChangesCheckbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconModeChangesCheckbox.TabIndex = 74;
            infoIconModeChangesCheckbox.TabStop = false;
            toolTipExpressionsForm.SetToolTip(infoIconModeChangesCheckbox, "Whether or not to update the graphed comparison\r\ndata when you change the normalization mode, \r\nabsolute mode, etc.\r\n\r\nIf disabled, the comparison values will remain\r\nexactly as-is.");
            // 
            // infoIconImperfectLoops
            // 
            infoIconImperfectLoops.Image = (Image)resources.GetObject("infoIconImperfectLoops.Image");
            infoIconImperfectLoops.Location = new Point(1454, 1040);
            infoIconImperfectLoops.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconImperfectLoops.Name = "infoIconImperfectLoops";
            infoIconImperfectLoops.Size = new Size(16, 16);
            infoIconImperfectLoops.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconImperfectLoops.TabIndex = 75;
            infoIconImperfectLoops.TabStop = false;
            toolTipExpressionsForm.SetToolTip(infoIconImperfectLoops, resources.GetString("infoIconImperfectLoops.ToolTip"));
            // 
            // infoIconAbsoluteModeExpressions
            // 
            infoIconAbsoluteModeExpressions.Image = (Image)resources.GetObject("infoIconAbsoluteModeExpressions.Image");
            infoIconAbsoluteModeExpressions.Location = new Point(784, 822);
            infoIconAbsoluteModeExpressions.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            infoIconAbsoluteModeExpressions.Name = "infoIconAbsoluteModeExpressions";
            infoIconAbsoluteModeExpressions.Size = new Size(16, 16);
            infoIconAbsoluteModeExpressions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            infoIconAbsoluteModeExpressions.TabIndex = 76;
            infoIconAbsoluteModeExpressions.TabStop = false;
            toolTipExpressionsForm.SetToolTip(infoIconAbsoluteModeExpressions, resources.GetString("infoIconAbsoluteModeExpressions.ToolTip"));
            // 
            // btnApplyToChecked
            // 
            btnApplyToChecked.Location = new Point(251, 1205);
            btnApplyToChecked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnApplyToChecked.Name = "btnApplyToChecked";
            btnApplyToChecked.Size = new Size(174, 45);
            btnApplyToChecked.TabIndex = 47;
            btnApplyToChecked.Text = "Copy To Checked";
            btnApplyToChecked.UseVisualStyleBackColor = true;
            btnApplyToChecked.Click += btnApplyToChecked_Click;
            // 
            // btnApplyToAnimated
            // 
            btnApplyToAnimated.Location = new Point(251, 1255);
            btnApplyToAnimated.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnApplyToAnimated.Name = "btnApplyToAnimated";
            btnApplyToAnimated.Size = new Size(174, 45);
            btnApplyToAnimated.TabIndex = 48;
            btnApplyToAnimated.Text = "Copy To Animated";
            btnApplyToAnimated.UseVisualStyleBackColor = true;
            btnApplyToAnimated.Click += btnApplyToAnimated_Click;
            // 
            // btnUncheckAll
            // 
            btnUncheckAll.Location = new Point(474, 1255);
            btnUncheckAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnUncheckAll.Name = "btnUncheckAll";
            btnUncheckAll.Size = new Size(126, 45);
            btnUncheckAll.TabIndex = 49;
            btnUncheckAll.Text = "Uncheck All";
            btnUncheckAll.UseVisualStyleBackColor = true;
            btnUncheckAll.Click += btnUncheckAll_Click;
            // 
            // btnResetExpressions
            // 
            btnResetExpressions.Location = new Point(474, 1094);
            btnResetExpressions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnResetExpressions.Name = "btnResetExpressions";
            btnResetExpressions.Size = new Size(119, 38);
            btnResetExpressions.TabIndex = 50;
            btnResetExpressions.Text = "Reset All";
            btnResetExpressions.UseVisualStyleBackColor = true;
            btnResetExpressions.Click += btnResetExpressions_Click;
            // 
            // btnCheckAll
            // 
            btnCheckAll.Location = new Point(474, 1205);
            btnCheckAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(126, 45);
            btnCheckAll.TabIndex = 51;
            btnCheckAll.Text = "Check All";
            btnCheckAll.UseVisualStyleBackColor = true;
            btnCheckAll.Click += btnCheckAll_Click;
            // 
            // btnExampleExp
            // 
            btnExampleExp.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExampleExp.Location = new Point(1173, 1094);
            btnExampleExp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnExampleExp.Name = "btnExampleExp";
            btnExampleExp.Size = new Size(264, 75);
            btnExampleExp.TabIndex = 56;
            btnExampleExp.Text = "t^(2*e)";
            btnExampleExp.UseVisualStyleBackColor = true;
            btnExampleExp.Click += btnExampleExpSin_Click;
            // 
            // btnExampleSine
            // 
            btnExampleSine.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExampleSine.Location = new Point(622, 1094);
            btnExampleSine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            btnExampleSine.Name = "btnExampleSine";
            btnExampleSine.Size = new Size(264, 75);
            btnExampleSine.TabIndex = 17;
            btnExampleSine.Text = "sin(2*pi*t)";
            btnExampleSine.UseVisualStyleBackColor = true;
            btnExampleSine.Click += btnExampleSin_Click;
            // 
            // dropdownExamplesNonLoops
            // 
            dropdownExamplesNonLoops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dropdownExamplesNonLoops.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dropdownExamplesNonLoops.FormattingEnabled = true;
            dropdownExamplesNonLoops.ItemHeight = 37;
            dropdownExamplesNonLoops.Items.AddRange(new object[] { "-tanh(2*cos(0.5*pi*t+pi*0.5))", "e/(t/3+.01)", "t^t", "abs(sin(pi*t))", "atan(exp(t*5))", "atan(exp(t*-5))", "0.04*cos(3*t) + 0.02*cos(10*t)", "-1*(t+sin(t*5*pi)/4)", "(t+sin(t*5*pi)/4)", "cos(exp(t*pi))" });
            dropdownExamplesNonLoops.Location = new Point(797, 919);
            dropdownExamplesNonLoops.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dropdownExamplesNonLoops.Name = "dropdownExamplesNonLoops";
            dropdownExamplesNonLoops.Size = new Size(650, 45);
            dropdownExamplesNonLoops.TabIndex = 64;
            dropdownExamplesNonLoops.SelectedIndexChanged += dropdownExampleNonLoops_SelectedIndexChanged;
            // 
            // labelExamplesNonLoops
            // 
            labelExamplesNonLoops.AutoSize = true;
            labelExamplesNonLoops.Font = new Font("Segoe UI", 12F);
            labelExamplesNonLoops.Location = new Point(651, 929);
            labelExamplesNonLoops.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelExamplesNonLoops.Name = "labelExamplesNonLoops";
            labelExamplesNonLoops.Size = new Size(138, 32);
            labelExamplesNonLoops.TabIndex = 65;
            labelExamplesNonLoops.Text = "Non-Loops:";
            // 
            // dropdownExampleLoops
            // 
            dropdownExampleLoops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dropdownExampleLoops.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dropdownExampleLoops.FormattingEnabled = true;
            dropdownExampleLoops.ItemHeight = 37;
            dropdownExampleLoops.Items.AddRange(new object[] { "exp(sin(2*pi*t))", "sin(2*pi*sin(2*pi*t))", "cos(2*pi*cos(pi*t))", "sin(2*pi*t)* exp(-sin(2*pi*t))", "(sin(2*pi*t))^3", "tanh(cos(2*pi*t))", "cos(2*pi*t)*exp(-cos(2*pi*t))", "atan(sin(2*pi*t))", "airyai(sin(2*pi*t))", "sech(tan(2*pi*t))", "-acsc(abs(sec(pi*(t))))", "atanh(sin(2*pi*t+.01))", "ln(abs(cos(pi*t)))", "abs(sin(2*pi*t) + cos(4*pi*t))", "acos(sech(tan(pi*t)))", "abs(sech(csc(2*pi*(t+.01))))" });
            dropdownExampleLoops.Location = new Point(796, 971);
            dropdownExampleLoops.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dropdownExampleLoops.Name = "dropdownExampleLoops";
            dropdownExampleLoops.Size = new Size(650, 45);
            dropdownExampleLoops.TabIndex = 66;
            dropdownExampleLoops.SelectedIndexChanged += dropdownExamplePerfectLoops_SelectedIndexChanged;
            // 
            // labelExamplesPerfectLoops
            // 
            labelExamplesPerfectLoops.AutoSize = true;
            labelExamplesPerfectLoops.Font = new Font("Segoe UI", 12F);
            labelExamplesPerfectLoops.Location = new Point(629, 981);
            labelExamplesPerfectLoops.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelExamplesPerfectLoops.Name = "labelExamplesPerfectLoops";
            labelExamplesPerfectLoops.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelExamplesPerfectLoops.Size = new Size(162, 32);
            labelExamplesPerfectLoops.TabIndex = 67;
            labelExamplesPerfectLoops.Text = "Perfect Loops:";
            // 
            // labelReplacingXWithT
            // 
            labelReplacingXWithT.AutoSize = true;
            labelReplacingXWithT.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelReplacingXWithT.ForeColor = Color.OrangeRed;
            labelReplacingXWithT.Location = new Point(743, 45);
            labelReplacingXWithT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelReplacingXWithT.Name = "labelReplacingXWithT";
            labelReplacingXWithT.Size = new Size(527, 44);
            labelReplacingXWithT.TabIndex = 68;
            labelReplacingXWithT.Text = "Warning: The 'x' in the expression will be evaluated as 't'.\r\nClick the graph preview button for details.";
            labelReplacingXWithT.Visible = false;
            // 
            // labelExamplesImperfectLoops
            // 
            labelExamplesImperfectLoops.AutoSize = true;
            labelExamplesImperfectLoops.Font = new Font("Segoe UI", 12F);
            labelExamplesImperfectLoops.Location = new Point(603, 1038);
            labelExamplesImperfectLoops.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelExamplesImperfectLoops.Name = "labelExamplesImperfectLoops";
            labelExamplesImperfectLoops.RightToLeft = System.Windows.Forms.RightToLeft.No;
            labelExamplesImperfectLoops.Size = new Size(191, 32);
            labelExamplesImperfectLoops.TabIndex = 70;
            labelExamplesImperfectLoops.Text = "Imperfect Loops:";
            // 
            // dropdownExamplesImperfectLoops
            // 
            dropdownExamplesImperfectLoops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dropdownExamplesImperfectLoops.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dropdownExamplesImperfectLoops.FormattingEnabled = true;
            dropdownExamplesImperfectLoops.ItemHeight = 37;
            dropdownExamplesImperfectLoops.Items.AddRange(new object[] { "sin(4*pi*t)*exp(-t)", "coth(cos(2*pi*t))", "sec(tan(pi*(t)))", "atan(1/4*csc(pi/2+pi*(t)))" });
            dropdownExamplesImperfectLoops.Location = new Point(797, 1026);
            dropdownExamplesImperfectLoops.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dropdownExamplesImperfectLoops.Name = "dropdownExamplesImperfectLoops";
            dropdownExamplesImperfectLoops.Size = new Size(650, 45);
            dropdownExamplesImperfectLoops.TabIndex = 69;
            dropdownExamplesImperfectLoops.SelectedIndexChanged += dropdownExamplesImperfectLoops_SelectedIndexChanged;
            // 
            // btnCompareSave
            // 
            btnCompareSave.Location = new Point(1087, 584);
            btnCompareSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCompareSave.Name = "btnCompareSave";
            btnCompareSave.Size = new Size(171, 38);
            btnCompareSave.TabIndex = 71;
            btnCompareSave.Text = "Save to Compare";
            btnCompareSave.UseVisualStyleBackColor = true;
            btnCompareSave.Click += btnCompareSave_Click;
            // 
            // btnResetCompare
            // 
            btnResetCompare.Location = new Point(1267, 584);
            btnResetCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnResetCompare.Name = "btnResetCompare";
            btnResetCompare.Size = new Size(171, 38);
            btnResetCompare.TabIndex = 72;
            btnResetCompare.Text = "Reset Comparison";
            btnResetCompare.UseVisualStyleBackColor = true;
            btnResetCompare.Click += btnResetCompare_Click;
            // 
            // checkBoxCompareUpdateNormalization
            // 
            checkBoxCompareUpdateNormalization.AutoSize = true;
            checkBoxCompareUpdateNormalization.Checked = true;
            checkBoxCompareUpdateNormalization.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxCompareUpdateNormalization.Location = new Point(1087, 633);
            checkBoxCompareUpdateNormalization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            checkBoxCompareUpdateNormalization.Name = "checkBoxCompareUpdateNormalization";
            checkBoxCompareUpdateNormalization.Size = new Size(334, 29);
            checkBoxCompareUpdateNormalization.TabIndex = 73;
            checkBoxCompareUpdateNormalization.Text = "Apply Mode Changes to Comparison";
            checkBoxCompareUpdateNormalization.UseVisualStyleBackColor = true;
            checkBoxCompareUpdateNormalization.CheckedChanged += checkBoxCompareUpdateNormalization_CheckedChanged;
            // 
            // btnShowFunctionInfo
            // 
            btnShowFunctionInfo.Location = new Point(1102, 1247);
            btnShowFunctionInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnShowFunctionInfo.Name = "btnShowFunctionInfo";
            btnShowFunctionInfo.Size = new Size(207, 53);
            btnShowFunctionInfo.TabIndex = 77;
            btnShowFunctionInfo.Text = "Supported Functions";
            btnShowFunctionInfo.UseVisualStyleBackColor = true;
            btnShowFunctionInfo.Click += btnShowFunctionInfo_Click;
            // 
            // txtComparedExpression
            // 
            txtComparedExpression.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComparedExpression.Location = new Point(1194, 669);
            txtComparedExpression.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtComparedExpression.Name = "txtComparedExpression";
            txtComparedExpression.ReadOnly = true;
            txtComparedExpression.Size = new Size(243, 31);
            txtComparedExpression.TabIndex = 78;
            // 
            // labelComparisonExpressionTextBox
            // 
            labelComparisonExpressionTextBox.AutoSize = true;
            labelComparisonExpressionTextBox.Enabled = false;
            labelComparisonExpressionTextBox.Location = new Point(1079, 678);
            labelComparisonExpressionTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelComparisonExpressionTextBox.Name = "labelComparisonExpressionTextBox";
            labelComparisonExpressionTextBox.Size = new Size(113, 25);
            labelComparisonExpressionTextBox.TabIndex = 79;
            labelComparisonExpressionTextBox.Text = "Comparison:";
            // 
            // checkBoxAutoUpdateMainWindow
            // 
            checkBoxAutoUpdateMainWindow.AutoSize = true;
            checkBoxAutoUpdateMainWindow.Checked = true;
            checkBoxAutoUpdateMainWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAutoUpdateMainWindow.Location = new Point(956, 811);
            checkBoxAutoUpdateMainWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            checkBoxAutoUpdateMainWindow.Name = "checkBoxAutoUpdateMainWindow";
            checkBoxAutoUpdateMainWindow.Size = new Size(419, 29);
            checkBoxAutoUpdateMainWindow.TabIndex = 80;
            checkBoxAutoUpdateMainWindow.Text = "Auto Update Main Window Custom Expressions";
            checkBoxAutoUpdateMainWindow.UseVisualStyleBackColor = true;
            // 
            // ExpressionsForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new Size(1493, 1317);
            Controls.Add(checkBoxAutoUpdateMainWindow);
            Controls.Add(labelComparisonExpressionTextBox);
            Controls.Add(txtComparedExpression);
            Controls.Add(btnShowFunctionInfo);
            Controls.Add(infoIconAbsoluteModeExpressions);
            Controls.Add(infoIconImperfectLoops);
            Controls.Add(infoIconModeChangesCheckbox);
            Controls.Add(checkBoxCompareUpdateNormalization);
            Controls.Add(btnResetCompare);
            Controls.Add(btnCompareSave);
            Controls.Add(labelExamplesImperfectLoops);
            Controls.Add(dropdownExamplesImperfectLoops);
            Controls.Add(labelReplacingXWithT);
            Controls.Add(labelExamplesPerfectLoops);
            Controls.Add(dropdownExampleLoops);
            Controls.Add(labelExamplesNonLoops);
            Controls.Add(dropdownExamplesNonLoops);
            Controls.Add(btnExampleExp);
            Controls.Add(infoIconCopyAnimated);
            Controls.Add(btnCheckAll);
            Controls.Add(btnResetExpressions);
            Controls.Add(btnUncheckAll);
            Controls.Add(btnApplyToAnimated);
            Controls.Add(btnApplyToChecked);
            Controls.Add(checkBoxAbsoluteMode);
            Controls.Add(groupBoxNormalizeRadiosClone);
            Controls.Add(labelErrorWhileGraphing);
            Controls.Add(btnExampleCosine);
            Controls.Add(labelExampleExpressionButtons);
            Controls.Add(btnExampleSine);
            Controls.Add(btnHelpExpressionsForm);
            Controls.Add(labelNoGraphToggleParam);
            Controls.Add(labelMasterIndexClone);
            Controls.Add(nudMasterParamIndexClone);
            Controls.Add(checkBoxAutoUpdateGraph);
            Controls.Add(nudGraphConstantFrameCount);
            Controls.Add(checkBoxKeepFramesConstant);
            Controls.Add(btnChartValues);
            Controls.Add(btnTestChart);
            Controls.Add(btnSendExpressionsStringToMainWindow);
            Controls.Add(labelCurrentExpressionString);
            Controls.Add(txtCurrentExpressionParamString);
            Controls.Add(dataGridViewExpressions);
            Name = "ExpressionsForm";
            Text = "Mathematical Expressions For Parameters";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpressions).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGraphConstantFrameCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMasterParamIndexClone).EndInit();
            groupBoxNormalizeRadiosClone.ResumeLayout(false);
            groupBoxNormalizeRadiosClone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoIconCopyAnimated).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconModeChangesCheckbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconImperfectLoops).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoIconAbsoluteModeExpressions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExpressions;
        private System.Windows.Forms.Label labelCurrentExpressionString;
        private System.Windows.Forms.TextBox txtCurrentExpressionParamString;
        private System.Windows.Forms.Button btnSendExpressionsStringToMainWindow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCurve;
        private System.Windows.Forms.Button btnTestChart;
        private System.Windows.Forms.Button btnChartValues;
        private System.Windows.Forms.CheckBox checkBoxKeepFramesConstant;
        private System.Windows.Forms.NumericUpDown nudGraphConstantFrameCount;
        private System.Windows.Forms.CheckBox checkBoxAutoUpdateGraph;
        private System.Windows.Forms.NumericUpDown nudMasterParamIndexClone;
        private System.Windows.Forms.Label labelMasterIndexClone;
        private System.Windows.Forms.Label labelNoGraphToggleParam;
        private System.Windows.Forms.Button btnHelpExpressionsForm;
        private System.Windows.Forms.Label labelExampleExpressionButtons;
        private System.Windows.Forms.Button btnExampleCosine;
        private System.Windows.Forms.Label labelErrorWhileGraphing;
        private System.Windows.Forms.GroupBox groupBoxNormalizeRadiosClone;
        private System.Windows.Forms.RadioButton radioNormalizeStartEndClone;
        private System.Windows.Forms.RadioButton radioNoNormalizeClone;
        private System.Windows.Forms.RadioButton radioNormalizeMaxRangesClone;
        private System.Windows.Forms.RadioButton radioNormalizeExtendedRangesClone;
        private System.Windows.Forms.CheckBox checkBoxAbsoluteMode;
        private System.Windows.Forms.ToolTip toolTipExpressionsForm;
        private System.Windows.Forms.Button btnApplyToChecked;
        private System.Windows.Forms.Button btnApplyToAnimated;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnResetExpressions;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.PictureBox infoIconCopyAnimated;
        private System.Windows.Forms.Button btnExampleExp;
        private System.Windows.Forms.Button btnExampleSine;
        private System.Windows.Forms.ComboBox dropdownExamplesNonLoops;
        private System.Windows.Forms.Label labelExamplesNonLoops;
        private System.Windows.Forms.ComboBox dropdownExampleLoops;
        private System.Windows.Forms.Label labelExamplesPerfectLoops;
        private System.Windows.Forms.Label labelReplacingXWithT;
        private System.Windows.Forms.Label labelExamplesImperfectLoops;
        private System.Windows.Forms.ComboBox dropdownExamplesImperfectLoops;
        private System.Windows.Forms.Button btnCompareSave;
        private System.Windows.Forms.Button btnResetCompare;
        private System.Windows.Forms.CheckBox checkBoxCompareUpdateNormalization;
        private System.Windows.Forms.PictureBox infoIconModeChangesCheckbox;
        private System.Windows.Forms.PictureBox infoIconImperfectLoops;
        private System.Windows.Forms.PictureBox infoIconAbsoluteModeExpressions;
        private System.Windows.Forms.Button btnShowFunctionInfo;
        private System.Windows.Forms.TextBox txtComparedExpression;
        private System.Windows.Forms.Label labelComparisonExpressionTextBox;
        private System.Windows.Forms.CheckBox checkBoxAutoUpdateMainWindow;
    }
}
