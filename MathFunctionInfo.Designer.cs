namespace GmicDrosteAnimate
{
    partial class MathFunctionInfo
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
            splitContainer = new System.Windows.Forms.SplitContainer();
            richTextBoxLeft = new System.Windows.Forms.RichTextBox();
            richTextBoxRight = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Location = new System.Drawing.Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(richTextBoxLeft);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(richTextBoxRight);
            splitContainer.Size = new System.Drawing.Size(1110, 589);
            splitContainer.SplitterDistance = 555;
            splitContainer.TabIndex = 0;
            // 
            // richTextBoxLeft
            // 
            richTextBoxLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBoxLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            richTextBoxLeft.Location = new System.Drawing.Point(0, 0);
            richTextBoxLeft.Name = "richTextBoxLeft";
            richTextBoxLeft.ReadOnly = true;
            richTextBoxLeft.Size = new System.Drawing.Size(555, 589);
            richTextBoxLeft.TabIndex = 0;
            richTextBoxLeft.Text = "";
            // 
            // richTextBoxRight
            // 
            richTextBoxRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBoxRight.Dock = System.Windows.Forms.DockStyle.Fill;
            richTextBoxRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            richTextBoxRight.Location = new System.Drawing.Point(0, 0);
            richTextBoxRight.Name = "richTextBoxRight";
            richTextBoxRight.ReadOnly = true;
            richTextBoxRight.Size = new System.Drawing.Size(551, 589);
            richTextBoxRight.TabIndex = 0;
            richTextBoxRight.Text = "";
            // 
            // MathFunctionInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1110, 589);
            Controls.Add(splitContainer);
            Name = "MathFunctionInfo";
            Text = "MathFunctionInfo";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.RichTextBox richTextBoxLeft;
        private System.Windows.Forms.RichTextBox richTextBoxRight;

        #endregion


        private void SetTabStops(System.Windows.Forms.RichTextBox richTextBox)
        {
            // Set the tab stops (in pixels)
            richTextBox.SelectionTabs = new int[] { 125 }; // Adjust the value to set the alignment
        }

        private void AddFunctionInfo()
        {
            var functionInfo = new (string command, string description)[]
            {
                ("abs", "Absolute value"),
                ("acos", "Arc cosine"),
                ("acosh", "Arc hyperbolic cosine"),
                ("acot", "Arc cotangent"),
                ("acoth", "Arc hyperbolic cotangent"),
                ("acsc", "Arc cosecant"),
                ("acsch", "Arc hyperbolic cosecant"),
                ("airyai", "Airy function Ai"),
                ("airyaiprime", "Derivative of Airy function Ai"),
                ("airybi", "Airy function Bi"),
                ("airybiprime", "Derivative of Airy function Bi"),
                ("asec", "Arc secant"),
                ("asech", "Arc hyperbolic secant"),
                ("asin", "Arc sine"),
                ("asinh", "Arc hyperbolic sine"),
                ("atan", "Arc tangent"),
                ("atanh", "Arc hyperbolic tangent"),
                ("cos", "Cosine"),
                ("cosh", "Hyperbolic cosine"),
                ("cot", "Cotangent"),
                ("coth", "Hyperbolic cotangent"),
                ("csc", "Cosecant"),
                ("csch", "Hyperbolic cosecant"),
                ("exp", "Exponential"),
                ("lg", "Logarithm base 10"),
                ("ln", "Natural logarithm"),
                ("sec", "Secant"),
                ("sech", "Hyperbolic secant"),
                ("sin", "Sine"),
                ("sinh", "Hyperbolic sine"),
                ("tan", "Tangent"),
                ("tanh", "Hyperbolic tangent"),
                ("pi", "Pi (Constant)"),
                ("e", "Euler's number (Constant)")
            };

            int half = functionInfo.Length / 2;
            for (int i = 0; i < functionInfo.Length; i++)
            {
                var (command, description) = functionInfo[i];
                if (i < half)
                {
                    AppendText(this.richTextBoxLeft, command, description);
                }
                else
                {
                    AppendText(this.richTextBoxRight, command, description);
                }
            }
        }

        private void AppendText(System.Windows.Forms.RichTextBox richTextBox, string command, string description)
        {
            int maxCommandLength = 17; // Set a max command length for padding
            richTextBox.SelectionFont = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            richTextBox.AppendText($" {command}");

            // Change font to Consolas Regular before appending periods
            richTextBox.SelectionFont = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular);
            int periodsToAdd = maxCommandLength - command.Length;
            for (int i = 0; i < periodsToAdd; i++)
            {
                richTextBox.AppendText(".");
            }

            // Append description with Microsoft Sans Serif Regular font
            richTextBox.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            richTextBox.AppendText($" {description}\n");
        }


    }
}
