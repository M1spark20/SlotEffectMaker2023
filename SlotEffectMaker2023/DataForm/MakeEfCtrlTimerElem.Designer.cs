
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeEfCtrlTimerElem
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
            this.rbStop = new System.Windows.Forms.RadioButton();
            this.rbStart = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTimerName = new System.Windows.Forms.ComboBox();
            this.chkForceReset = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDataName = new System.Windows.Forms.TextBox();
            this.tbUsage = new System.Windows.Forms.TextBox();
            this.pnCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "タイマ制御内容";
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
            this.label2.Size = new System.Drawing.Size(87, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "タイマ強制リセット";
            // 
            // pnCond
            // 
            this.pnCond.Controls.Add(this.rbStop);
            this.pnCond.Controls.Add(this.rbStart);
            this.pnCond.Location = new System.Drawing.Point(145, 70);
            this.pnCond.Name = "pnCond";
            this.pnCond.Size = new System.Drawing.Size(150, 16);
            this.pnCond.TabIndex = 3;
            // 
            // rbStop
            // 
            this.rbStop.AutoSize = true;
            this.rbStop.Location = new System.Drawing.Point(103, 0);
            this.rbStop.Name = "rbStop";
            this.rbStop.Size = new System.Drawing.Size(47, 16);
            this.rbStop.TabIndex = 2;
            this.rbStop.Text = "停止";
            this.rbStop.UseVisualStyleBackColor = true;
            this.rbStop.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbStart
            // 
            this.rbStart.AutoSize = true;
            this.rbStart.Checked = true;
            this.rbStart.Location = new System.Drawing.Point(0, 0);
            this.rbStart.Name = "rbStart";
            this.rbStart.Size = new System.Drawing.Size(47, 16);
            this.rbStart.TabIndex = 1;
            this.rbStart.TabStop = true;
            this.rbStart.Text = "作動";
            this.rbStart.UseVisualStyleBackColor = true;
            this.rbStart.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "タイマ制御先";
            // 
            // cbTimerName
            // 
            this.cbTimerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimerName.FormattingEnabled = true;
            this.cbTimerName.ItemHeight = 12;
            this.cbTimerName.Location = new System.Drawing.Point(145, 127);
            this.cbTimerName.Name = "cbTimerName";
            this.cbTimerName.Size = new System.Drawing.Size(150, 20);
            this.cbTimerName.TabIndex = 5;
            // 
            // chkForceReset
            // 
            this.chkForceReset.AutoSize = true;
            this.chkForceReset.Location = new System.Drawing.Point(145, 99);
            this.chkForceReset.Name = "chkForceReset";
            this.chkForceReset.Size = new System.Drawing.Size(104, 16);
            this.chkForceReset.TabIndex = 4;
            this.chkForceReset.Text = "強制リセット有効";
            this.chkForceReset.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "データ名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "用途";
            // 
            // tbDataName
            // 
            this.tbDataName.Location = new System.Drawing.Point(145, 7);
            this.tbDataName.Name = "tbDataName";
            this.tbDataName.Size = new System.Drawing.Size(150, 19);
            this.tbDataName.TabIndex = 1;
            // 
            // tbUsage
            // 
            this.tbUsage.Location = new System.Drawing.Point(145, 37);
            this.tbUsage.Name = "tbUsage";
            this.tbUsage.Size = new System.Drawing.Size(150, 19);
            this.tbUsage.TabIndex = 2;
            // 
            // MakeEfCtrlTimerElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 189);
            this.ControlBox = false;
            this.Controls.Add(this.tbUsage);
            this.Controls.Add(this.tbDataName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkForceReset);
            this.Controls.Add(this.pnCond);
            this.Controls.Add(this.cbTimerName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeEfCtrlTimerElem";
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
        private System.Windows.Forms.RadioButton rbStop;
        private System.Windows.Forms.RadioButton rbStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTimerName;
        private System.Windows.Forms.CheckBox chkForceReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDataName;
        private System.Windows.Forms.TextBox tbUsage;
    }
}