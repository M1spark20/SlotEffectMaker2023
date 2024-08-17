
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeFlagCounterElem
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
            this.labelNum = new System.Windows.Forms.Label();
            this.numFlag1 = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.labelAct = new System.Windows.Forms.Label();
            this.cbVarName = new System.Windows.Forms.ComboBox();
            this.numFlag2 = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFlag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFlag2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(10, 13);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(89, 12);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "カウントフラグ範囲";
            // 
            // numFlag1
            // 
            this.numFlag1.Location = new System.Drawing.Point(145, 10);
            this.numFlag1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numFlag1.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numFlag1.Name = "numFlag1";
            this.numFlag1.Size = new System.Drawing.Size(65, 19);
            this.numFlag1.TabIndex = 0;
            this.numFlag1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(225, 61);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 11;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(145, 61);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // labelAct
            // 
            this.labelAct.AutoSize = true;
            this.labelAct.Location = new System.Drawing.Point(10, 38);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(65, 12);
            this.labelAct.TabIndex = 0;
            this.labelAct.Text = "出力先変数";
            // 
            // cbVarName
            // 
            this.cbVarName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVarName.FormattingEnabled = true;
            this.cbVarName.ItemHeight = 12;
            this.cbVarName.Location = new System.Drawing.Point(145, 35);
            this.cbVarName.Name = "cbVarName";
            this.cbVarName.Size = new System.Drawing.Size(150, 20);
            this.cbVarName.TabIndex = 2;
            // 
            // numFlag2
            // 
            this.numFlag2.Location = new System.Drawing.Point(230, 10);
            this.numFlag2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numFlag2.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numFlag2.Name = "numFlag2";
            this.numFlag2.Size = new System.Drawing.Size(65, 19);
            this.numFlag2.TabIndex = 1;
            this.numFlag2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "～";
            // 
            // MakeFlagCounterElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 94);
            this.ControlBox = false;
            this.Controls.Add(this.cbVarName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.numFlag2);
            this.Controls.Add(this.numFlag1);
            this.Controls.Add(this.labelAct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeFlagCounterElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeFlagCounterElem";
            ((System.ComponentModel.ISupportInitialize)(this.numFlag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFlag2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numFlag1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.ComboBox cbVarName;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numFlag2;
        private System.Windows.Forms.Label label1;
    }
}