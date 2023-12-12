
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeSingleValCond
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
            this.numRange1 = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numRange2 = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.label4 = new System.Windows.Forms.Label();
            this.chkInv = new System.Windows.Forms.CheckBox();
            this.cbVar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRange1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRange2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "比較変数";
            // 
            // numRange1
            // 
            this.numRange1.Location = new System.Drawing.Point(145, 35);
            this.numRange1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numRange1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numRange1.Name = "numRange1";
            this.numRange1.Size = new System.Drawing.Size(60, 19);
            this.numRange1.TabIndex = 2;
            this.numRange1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(225, 85);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 11;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(145, 85);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "条件成立範囲";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "論理反転";
            // 
            // numRange2
            // 
            this.numRange2.Location = new System.Drawing.Point(235, 35);
            this.numRange2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numRange2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numRange2.Name = "numRange2";
            this.numRange2.Size = new System.Drawing.Size(60, 19);
            this.numRange2.TabIndex = 3;
            this.numRange2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "～";
            // 
            // chkInv
            // 
            this.chkInv.AutoSize = true;
            this.chkInv.Location = new System.Drawing.Point(145, 62);
            this.chkInv.Name = "chkInv";
            this.chkInv.Size = new System.Drawing.Size(67, 16);
            this.chkInv.TabIndex = 4;
            this.chkInv.Text = "反転する";
            this.chkInv.UseVisualStyleBackColor = true;
            // 
            // cbVar
            // 
            this.cbVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVar.FormattingEnabled = true;
            this.cbVar.Location = new System.Drawing.Point(145, 10);
            this.cbVar.Name = "cbVar";
            this.cbVar.Size = new System.Drawing.Size(150, 20);
            this.cbVar.TabIndex = 1;
            // 
            // MakeSingleValCond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 117);
            this.ControlBox = false;
            this.Controls.Add(this.cbVar);
            this.Controls.Add(this.chkInv);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.numRange2);
            this.Controls.Add(this.numRange1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeSingleValCond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeSingleValCond";
            ((System.ComponentModel.ISupportInitialize)(this.numRange1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRange2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numRange1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numRange2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkInv;
        private System.Windows.Forms.ComboBox cbVar;
    }
}