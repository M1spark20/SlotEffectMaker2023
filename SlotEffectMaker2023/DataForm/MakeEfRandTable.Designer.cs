
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeEfRandTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.numDecVal = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txtVarNameBase = new System.Windows.Forms.Label();
            this.numApplyBase = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            ((System.ComponentModel.ISupportInitialize)(this.numDecVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numApplyBase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "乱数減算値";
            // 
            // numDecVal
            // 
            this.numDecVal.Location = new System.Drawing.Point(145, 10);
            this.numDecVal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDecVal.Name = "numDecVal";
            this.numDecVal.Size = new System.Drawing.Size(150, 19);
            this.numDecVal.TabIndex = 0;
            this.numDecVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(225, 61);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 1001;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(145, 61);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 23);
            this.BtnCancel.TabIndex = 1000;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtVarNameBase
            // 
            this.txtVarNameBase.AutoSize = true;
            this.txtVarNameBase.Location = new System.Drawing.Point(10, 38);
            this.txtVarNameBase.Name = "txtVarNameBase";
            this.txtVarNameBase.Size = new System.Drawing.Size(77, 12);
            this.txtVarNameBase.TabIndex = 0;
            this.txtVarNameBase.Text = "当選時設定値";
            // 
            // numApplyBase
            // 
            this.numApplyBase.Location = new System.Drawing.Point(145, 35);
            this.numApplyBase.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numApplyBase.Name = "numApplyBase";
            this.numApplyBase.Size = new System.Drawing.Size(150, 19);
            this.numApplyBase.TabIndex = 10;
            this.numApplyBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MakeEfRandTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 94);
            this.ControlBox = false;
            this.Controls.Add(this.numApplyBase);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.numDecVal);
            this.Controls.Add(this.txtVarNameBase);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeEfRandTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeEfRandTable";
            ((System.ComponentModel.ISupportInitialize)(this.numDecVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numApplyBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numDecVal;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label txtVarNameBase;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numApplyBase;
    }
}