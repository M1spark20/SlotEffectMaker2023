
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeEfCondTrig
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
            this.cbActName = new System.Windows.Forms.ComboBox();
            this.pnCond = new System.Windows.Forms.Panel();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.pnCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "動作条件";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "合致時アクション";
            // 
            // cbActName
            // 
            this.cbActName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActName.FormattingEnabled = true;
            this.cbActName.ItemHeight = 12;
            this.cbActName.Location = new System.Drawing.Point(145, 35);
            this.cbActName.Name = "cbActName";
            this.cbActName.Size = new System.Drawing.Size(150, 20);
            this.cbActName.TabIndex = 5;
            // 
            // pnCond
            // 
            this.pnCond.Controls.Add(this.rbFalse);
            this.pnCond.Controls.Add(this.rbTrue);
            this.pnCond.Location = new System.Drawing.Point(145, 13);
            this.pnCond.Name = "pnCond";
            this.pnCond.Size = new System.Drawing.Size(150, 16);
            this.pnCond.TabIndex = 1;
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Location = new System.Drawing.Point(92, 0);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(58, 16);
            this.rbFalse.TabIndex = 2;
            this.rbFalse.Text = "FALSE";
            this.rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Checked = true;
            this.rbTrue.Location = new System.Drawing.Point(0, 0);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(53, 16);
            this.rbTrue.TabIndex = 1;
            this.rbTrue.TabStop = true;
            this.rbTrue.Text = "TRUE";
            this.rbTrue.UseVisualStyleBackColor = true;
            // 
            // MakeEfCondTrig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 94);
            this.ControlBox = false;
            this.Controls.Add(this.pnCond);
            this.Controls.Add(this.cbActName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeEfCondTrig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeEfCondTrig";
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
        private System.Windows.Forms.ComboBox cbActName;
        private System.Windows.Forms.Panel pnCond;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
    }
}