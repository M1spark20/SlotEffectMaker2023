
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeEfVarOP
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVarName = new System.Windows.Forms.ComboBox();
            this.pnCond = new System.Windows.Forms.Panel();
            this.rbFix = new System.Windows.Forms.RadioButton();
            this.rbVar = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.numFixVal = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOperand = new System.Windows.Forms.ComboBox();
            this.pnCond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFixVal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "右辺データ種別";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(225, 125);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 11;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(145, 125);
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
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "右辺データ(変数)";
            // 
            // cbVarName
            // 
            this.cbVarName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVarName.FormattingEnabled = true;
            this.cbVarName.ItemHeight = 12;
            this.cbVarName.Location = new System.Drawing.Point(145, 37);
            this.cbVarName.Name = "cbVarName";
            this.cbVarName.Size = new System.Drawing.Size(150, 20);
            this.cbVarName.TabIndex = 3;
            // 
            // pnCond
            // 
            this.pnCond.Controls.Add(this.rbFix);
            this.pnCond.Controls.Add(this.rbVar);
            this.pnCond.Location = new System.Drawing.Point(145, 10);
            this.pnCond.Name = "pnCond";
            this.pnCond.Size = new System.Drawing.Size(150, 16);
            this.pnCond.TabIndex = 1;
            // 
            // rbFix
            // 
            this.rbFix.AutoSize = true;
            this.rbFix.Location = new System.Drawing.Point(91, 0);
            this.rbFix.Name = "rbFix";
            this.rbFix.Size = new System.Drawing.Size(59, 16);
            this.rbFix.TabIndex = 2;
            this.rbFix.Text = "固定値";
            this.rbFix.UseVisualStyleBackColor = true;
            this.rbFix.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbVar
            // 
            this.rbVar.AutoSize = true;
            this.rbVar.Checked = true;
            this.rbVar.Location = new System.Drawing.Point(0, 0);
            this.rbVar.Name = "rbVar";
            this.rbVar.Size = new System.Drawing.Size(47, 16);
            this.rbVar.TabIndex = 1;
            this.rbVar.TabStop = true;
            this.rbVar.Text = "変数";
            this.rbVar.UseVisualStyleBackColor = true;
            this.rbVar.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "右辺データ(固定値)";
            // 
            // numFixVal
            // 
            this.numFixVal.Location = new System.Drawing.Point(145, 68);
            this.numFixVal.Name = "numFixVal";
            this.numFixVal.Size = new System.Drawing.Size(150, 19);
            this.numFixVal.TabIndex = 4;
            this.numFixVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "オペランド";
            // 
            // cbOperand
            // 
            this.cbOperand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperand.FormattingEnabled = true;
            this.cbOperand.ItemHeight = 12;
            this.cbOperand.Location = new System.Drawing.Point(145, 97);
            this.cbOperand.Name = "cbOperand";
            this.cbOperand.Size = new System.Drawing.Size(150, 20);
            this.cbOperand.TabIndex = 5;
            // 
            // MakeEfVarOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 159);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numFixVal);
            this.Controls.Add(this.pnCond);
            this.Controls.Add(this.cbOperand);
            this.Controls.Add(this.cbVarName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeEfVarOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeEfVarOP";
            this.pnCond.ResumeLayout(false);
            this.pnCond.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFixVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVarName;
        private System.Windows.Forms.Panel pnCond;
        private System.Windows.Forms.RadioButton rbFix;
        private System.Windows.Forms.RadioButton rbVar;
        private System.Windows.Forms.Label label3;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numFixVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOperand;
    }
}