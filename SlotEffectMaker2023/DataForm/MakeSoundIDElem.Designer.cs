
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeSoundIDElem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDataName = new System.Windows.Forms.TextBox();
            this.tbShotRes = new System.Windows.Forms.TextBox();
            this.tbLoopRes = new System.Windows.Forms.TextBox();
            this.numLoopTime = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLoopTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "音源データ名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "単発/イントロ音源リソース";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "ループ音源リソース";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "ループ開始時間[ms]";
            // 
            // tbDataName
            // 
            this.tbDataName.Location = new System.Drawing.Point(145, 10);
            this.tbDataName.Name = "tbDataName";
            this.tbDataName.Size = new System.Drawing.Size(150, 19);
            this.tbDataName.TabIndex = 1;
            // 
            // tbShotRes
            // 
            this.tbShotRes.Location = new System.Drawing.Point(145, 35);
            this.tbShotRes.Name = "tbShotRes";
            this.tbShotRes.Size = new System.Drawing.Size(150, 19);
            this.tbShotRes.TabIndex = 2;
            // 
            // tbLoopRes
            // 
            this.tbLoopRes.Location = new System.Drawing.Point(145, 60);
            this.tbLoopRes.Name = "tbLoopRes";
            this.tbLoopRes.Size = new System.Drawing.Size(150, 19);
            this.tbLoopRes.TabIndex = 3;
            // 
            // numLoopTime
            // 
            this.numLoopTime.Location = new System.Drawing.Point(145, 85);
            this.numLoopTime.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numLoopTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numLoopTime.Name = "numLoopTime";
            this.numLoopTime.Size = new System.Drawing.Size(150, 19);
            this.numLoopTime.TabIndex = 4;
            this.numLoopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLoopTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(225, 110);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 11;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.OK);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(145, 110);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 23);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // MakeSoundIDElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(305, 142);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.numLoopTime);
            this.Controls.Add(this.tbLoopRes);
            this.Controls.Add(this.tbShotRes);
            this.Controls.Add(this.tbDataName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeSoundIDElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeSoundID";
            ((System.ComponentModel.ISupportInitialize)(this.numLoopTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDataName;
        private System.Windows.Forms.TextBox tbShotRes;
        private System.Windows.Forms.TextBox tbLoopRes;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numLoopTime;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}