
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeActionSwitchElem
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
            this.numCheckVal = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.labelAct = new System.Windows.Forms.Label();
            this.cbActName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCheckVal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(10, 13);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(41, 12);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "変数値";
            // 
            // numCheckVal
            // 
            this.numCheckVal.Location = new System.Drawing.Point(145, 10);
            this.numCheckVal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCheckVal.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numCheckVal.Name = "numCheckVal";
            this.numCheckVal.Size = new System.Drawing.Size(150, 19);
            this.numCheckVal.TabIndex = 0;
            this.numCheckVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.labelAct.Size = new System.Drawing.Size(83, 12);
            this.labelAct.TabIndex = 0;
            this.labelAct.Text = "合致時アクション";
            // 
            // cbActName
            // 
            this.cbActName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActName.FormattingEnabled = true;
            this.cbActName.ItemHeight = 12;
            this.cbActName.Location = new System.Drawing.Point(145, 35);
            this.cbActName.Name = "cbActName";
            this.cbActName.Size = new System.Drawing.Size(150, 20);
            this.cbActName.TabIndex = 12;
            // 
            // MakeActionSwitchElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 94);
            this.ControlBox = false;
            this.Controls.Add(this.cbActName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.numCheckVal);
            this.Controls.Add(this.labelAct);
            this.Controls.Add(this.labelNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeActionSwitchElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeVariableElem";
            ((System.ComponentModel.ISupportInitialize)(this.numCheckVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numCheckVal;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.ComboBox cbActName;
    }
}