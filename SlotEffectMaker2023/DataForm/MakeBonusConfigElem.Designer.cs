
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeBonusConfigElem
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.labelAct = new System.Windows.Forms.Label();
            this.cbSymbolID = new System.Windows.Forms.ComboBox();
            this.cbTypeID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBonusID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(10, 13);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(55, 12);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "ボーナスID";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(225, 90);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 11;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(145, 90);
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
            this.labelAct.Size = new System.Drawing.Size(79, 12);
            this.labelAct.TabIndex = 0;
            this.labelAct.Text = "履歴シンボルID";
            // 
            // cbSymbolID
            // 
            this.cbSymbolID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSymbolID.FormattingEnabled = true;
            this.cbSymbolID.ItemHeight = 12;
            this.cbSymbolID.Location = new System.Drawing.Point(145, 35);
            this.cbSymbolID.Name = "cbSymbolID";
            this.cbSymbolID.Size = new System.Drawing.Size(150, 20);
            this.cbSymbolID.TabIndex = 2;
            // 
            // cbTypeID
            // 
            this.cbTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeID.FormattingEnabled = true;
            this.cbTypeID.ItemHeight = 12;
            this.cbTypeID.Location = new System.Drawing.Point(145, 60);
            this.cbTypeID.Name = "cbTypeID";
            this.cbTypeID.Size = new System.Drawing.Size(150, 20);
            this.cbTypeID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ボーナスカウント種別";
            // 
            // cbBonusID
            // 
            this.cbBonusID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBonusID.FormattingEnabled = true;
            this.cbBonusID.ItemHeight = 12;
            this.cbBonusID.Location = new System.Drawing.Point(145, 10);
            this.cbBonusID.Name = "cbBonusID";
            this.cbBonusID.Size = new System.Drawing.Size(150, 20);
            this.cbBonusID.TabIndex = 1;
            // 
            // MakeBonusConfigElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 122);
            this.ControlBox = false;
            this.Controls.Add(this.cbTypeID);
            this.Controls.Add(this.cbBonusID);
            this.Controls.Add(this.cbSymbolID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAct);
            this.Controls.Add(this.labelNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeBonusConfigElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeBonusConfigElem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.ComboBox cbSymbolID;
        private System.Windows.Forms.ComboBox cbTypeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBonusID;
    }
}