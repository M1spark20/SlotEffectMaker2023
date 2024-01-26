
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeDataShifterElem
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
            this.txtPlName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDefName = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.cbUseTimer = new System.Windows.Forms.ComboBox();
            this.numStartTime = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.numStopTime = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.cbDefSound = new System.Windows.Forms.ComboBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopTime)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlName
            // 
            this.txtPlName.AutoSize = true;
            this.txtPlName.Location = new System.Drawing.Point(10, 13);
            this.txtPlName.Name = "txtPlName";
            this.txtPlName.Size = new System.Drawing.Size(64, 12);
            this.txtPlName.TabIndex = 1;
            this.txtPlName.Text = "プレイヤー名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "使用タイマ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "再生開始時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "再生終了時間";
            // 
            // txtDefName
            // 
            this.txtDefName.AutoSize = true;
            this.txtDefName.Location = new System.Drawing.Point(10, 124);
            this.txtDefName.Name = "txtDefName";
            this.txtDefName.Size = new System.Drawing.Size(73, 12);
            this.txtDefName.TabIndex = 1;
            this.txtDefName.Text = "デフォルト音源";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Location = new System.Drawing.Point(90, 10);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(150, 19);
            this.tbPlayerName.TabIndex = 2;
            // 
            // cbUseTimer
            // 
            this.cbUseTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUseTimer.FormattingEnabled = true;
            this.cbUseTimer.Location = new System.Drawing.Point(90, 35);
            this.cbUseTimer.Name = "cbUseTimer";
            this.cbUseTimer.Size = new System.Drawing.Size(150, 20);
            this.cbUseTimer.TabIndex = 3;
            // 
            // numStartTime
            // 
            this.numStartTime.Location = new System.Drawing.Point(90, 70);
            this.numStartTime.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numStartTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numStartTime.Name = "numStartTime";
            this.numStartTime.Size = new System.Drawing.Size(150, 19);
            this.numStartTime.TabIndex = 5;
            this.numStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStartTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // numStopTime
            // 
            this.numStopTime.Location = new System.Drawing.Point(90, 95);
            this.numStopTime.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numStopTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numStopTime.Name = "numStopTime";
            this.numStopTime.Size = new System.Drawing.Size(150, 19);
            this.numStopTime.TabIndex = 5;
            this.numStopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStopTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // cbDefSound
            // 
            this.cbDefSound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefSound.FormattingEnabled = true;
            this.cbDefSound.Location = new System.Drawing.Point(90, 120);
            this.cbDefSound.Name = "cbDefSound";
            this.cbDefSound.Size = new System.Drawing.Size(150, 20);
            this.cbDefSound.TabIndex = 3;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(90, 146);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 23);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(170, 146);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 13;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // MakeSoundPlayElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(251, 178);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.numStopTime);
            this.Controls.Add(this.numStartTime);
            this.Controls.Add(this.cbDefSound);
            this.Controls.Add(this.cbUseTimer);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.txtDefName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeSoundPlayElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeSoundPlayElem";
            ((System.ComponentModel.ISupportInitialize)(this.numStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStopTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPlName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDefName;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.ComboBox cbUseTimer;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numStartTime;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numStopTime;
        private System.Windows.Forms.ComboBox cbDefSound;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
    }
}