﻿namespace GmicDrosteAnimate
{
    partial class ParamNamesForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtCurrentStartParamString = new System.Windows.Forms.TextBox();
            this.labelCurrentStartParamString = new System.Windows.Forms.Label();
            this.labelCurrentEndParamString = new System.Windows.Forms.Label();
            this.txtCurrentEndParamString = new System.Windows.Forms.TextBox();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.checkBoxStaticOptions = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 584);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(111, 718);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(118, 30);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Randomize Selected";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtCurrentStartParamString
            // 
            this.txtCurrentStartParamString.Location = new System.Drawing.Point(27, 626);
            this.txtCurrentStartParamString.Name = "txtCurrentStartParamString";
            this.txtCurrentStartParamString.ReadOnly = true;
            this.txtCurrentStartParamString.Size = new System.Drawing.Size(399, 20);
            this.txtCurrentStartParamString.TabIndex = 2;
            // 
            // labelCurrentStartParamString
            // 
            this.labelCurrentStartParamString.AutoSize = true;
            this.labelCurrentStartParamString.Location = new System.Drawing.Point(27, 611);
            this.labelCurrentStartParamString.Name = "labelCurrentStartParamString";
            this.labelCurrentStartParamString.Size = new System.Drawing.Size(167, 13);
            this.labelCurrentStartParamString.TabIndex = 3;
            this.labelCurrentStartParamString.Text = "Current String of Start Parameters:";
            this.labelCurrentStartParamString.Click += new System.EventHandler(this.labelCurrentParamString_Click);
            // 
            // labelCurrentEndParamString
            // 
            this.labelCurrentEndParamString.AutoSize = true;
            this.labelCurrentEndParamString.Location = new System.Drawing.Point(27, 654);
            this.labelCurrentEndParamString.Name = "labelCurrentEndParamString";
            this.labelCurrentEndParamString.Size = new System.Drawing.Size(164, 13);
            this.labelCurrentEndParamString.TabIndex = 5;
            this.labelCurrentEndParamString.Text = "Current String of End Parameters:";
            // 
            // txtCurrentEndParamString
            // 
            this.txtCurrentEndParamString.Location = new System.Drawing.Point(27, 669);
            this.txtCurrentEndParamString.Name = "txtCurrentEndParamString";
            this.txtCurrentEndParamString.ReadOnly = true;
            this.txtCurrentEndParamString.Size = new System.Drawing.Size(399, 20);
            this.txtCurrentEndParamString.TabIndex = 4;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(30, 695);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 6;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.Location = new System.Drawing.Point(30, 725);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnUncheckAll.TabIndex = 7;
            this.btnUncheckAll.Text = "Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(351, 598);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(75, 23);
            this.btnResetAll.TabIndex = 8;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // checkBoxStaticOptions
            // 
            this.checkBoxStaticOptions.AutoSize = true;
            this.checkBoxStaticOptions.Checked = true;
            this.checkBoxStaticOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStaticOptions.Location = new System.Drawing.Point(261, 738);
            this.checkBoxStaticOptions.Name = "checkBoxStaticOptions";
            this.checkBoxStaticOptions.Size = new System.Drawing.Size(176, 17);
            this.checkBoxStaticOptions.TabIndex = 9;
            this.checkBoxStaticOptions.Text = "Don\'t Randomize Static Options";
            this.checkBoxStaticOptions.UseVisualStyleBackColor = true;
            // 
            // ParamNamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 774);
            this.Controls.Add(this.checkBoxStaticOptions);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.labelCurrentEndParamString);
            this.Controls.Add(this.txtCurrentEndParamString);
            this.Controls.Add(this.labelCurrentStartParamString);
            this.Controls.Add(this.txtCurrentStartParamString);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.listView1);
            this.Name = "ParamNamesForm";
            this.Text = "ParamNamesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtCurrentStartParamString;
        private System.Windows.Forms.Label labelCurrentStartParamString;
        private System.Windows.Forms.Label labelCurrentEndParamString;
        private System.Windows.Forms.TextBox txtCurrentEndParamString;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.CheckBox checkBoxStaticOptions;
    }
}