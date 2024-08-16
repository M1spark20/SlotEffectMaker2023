
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeGameAchievementElem
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
            this.pnCond = new System.Windows.Forms.Panel();
            this.rbFlag = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVarName = new System.Windows.Forms.ComboBox();
            this.chkOnlyBonus = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDataName = new System.Windows.Forms.TextBox();
            this.cbCondName = new System.Windows.Forms.ComboBox();
            this.pnCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "データ保存変数";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(225, 155);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 11;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(145, 155);
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
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "実績達成条件";
            // 
            // pnCond
            // 
            this.pnCond.Controls.Add(this.rbFlag);
            this.pnCond.Controls.Add(this.rbData);
            this.pnCond.Location = new System.Drawing.Point(145, 40);
            this.pnCond.Name = "pnCond";
            this.pnCond.Size = new System.Drawing.Size(150, 16);
            this.pnCond.TabIndex = 2;
            // 
            // rbFlag
            // 
            this.rbFlag.AutoSize = true;
            this.rbFlag.Location = new System.Drawing.Point(84, 0);
            this.rbFlag.Name = "rbFlag";
            this.rbFlag.Size = new System.Drawing.Size(71, 16);
            this.rbFlag.TabIndex = 3;
            this.rbFlag.Text = "達成条件";
            this.rbFlag.UseVisualStyleBackColor = true;
            this.rbFlag.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Checked = true;
            this.rbData.Location = new System.Drawing.Point(0, 0);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(51, 16);
            this.rbData.TabIndex = 2;
            this.rbData.TabStop = true;
            this.rbData.Text = "データ";
            this.rbData.UseVisualStyleBackColor = true;
            this.rbData.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "評価タイミング";
            // 
            // cbVarName
            // 
            this.cbVarName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVarName.FormattingEnabled = true;
            this.cbVarName.ItemHeight = 12;
            this.cbVarName.Location = new System.Drawing.Point(145, 67);
            this.cbVarName.Name = "cbVarName";
            this.cbVarName.Size = new System.Drawing.Size(150, 20);
            this.cbVarName.TabIndex = 5;
            // 
            // chkOnlyBonus
            // 
            this.chkOnlyBonus.AutoSize = true;
            this.chkOnlyBonus.Location = new System.Drawing.Point(145, 127);
            this.chkOnlyBonus.Name = "chkOnlyBonus";
            this.chkOnlyBonus.Size = new System.Drawing.Size(120, 16);
            this.chkOnlyBonus.TabIndex = 7;
            this.chkOnlyBonus.Text = "ボーナス中のみ評価";
            this.chkOnlyBonus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "データID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "データ種別";
            // 
            // tbDataName
            // 
            this.tbDataName.Location = new System.Drawing.Point(145, 7);
            this.tbDataName.Name = "tbDataName";
            this.tbDataName.Size = new System.Drawing.Size(150, 19);
            this.tbDataName.TabIndex = 1;
            // 
            // cbCondName
            // 
            this.cbCondName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondName.FormattingEnabled = true;
            this.cbCondName.ItemHeight = 12;
            this.cbCondName.Location = new System.Drawing.Point(145, 97);
            this.cbCondName.Name = "cbCondName";
            this.cbCondName.Size = new System.Drawing.Size(150, 20);
            this.cbCondName.TabIndex = 6;
            // 
            // MakeGameAchievementElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 189);
            this.ControlBox = false;
            this.Controls.Add(this.tbDataName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkOnlyBonus);
            this.Controls.Add(this.pnCond);
            this.Controls.Add(this.cbCondName);
            this.Controls.Add(this.cbVarName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeGameAchievementElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeEfCtrlTimer";
            this.pnCond.ResumeLayout(false);
            this.pnCond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnCond;
        private System.Windows.Forms.RadioButton rbFlag;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVarName;
        private System.Windows.Forms.CheckBox chkOnlyBonus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDataName;
        private System.Windows.Forms.ComboBox cbCondName;
    }
}