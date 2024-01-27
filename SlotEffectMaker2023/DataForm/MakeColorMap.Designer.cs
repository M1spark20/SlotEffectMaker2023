
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeColorMap
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numTrigTime = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.numLoopCnt = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.chkFade = new System.Windows.Forms.CheckBox();
            this.picCardImg = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadImage = new System.Windows.Forms.Button();
            this.btnExportImage = new System.Windows.Forms.Button();
            this.btnShiftLeft = new System.Windows.Forms.Button();
            this.btnShiftRight = new System.Windows.Forms.Button();
            this.txtCardShow = new System.Windows.Forms.Label();
            this.fdReadMap = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.cbReadDirection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numExtRate = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAnimType = new System.Windows.Forms.ComboBox();
            this.fdSaveMap = new System.Windows.Forms.SaveFileDialog();
            this.numFactor = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            ((System.ComponentModel.ISupportInitialize)(this.numTrigTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoopCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(320, 271);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 21;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(240, 271);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 23);
            this.BtnCancel.TabIndex = 20;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "描画開始時間[ms]";
            // 
            // numTrigTime
            // 
            this.numTrigTime.Location = new System.Drawing.Point(10, 25);
            this.numTrigTime.Name = "numTrigTime";
            this.numTrigTime.Size = new System.Drawing.Size(121, 19);
            this.numTrigTime.TabIndex = 0;
            this.numTrigTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numLoopCnt
            // 
            this.numLoopCnt.Location = new System.Drawing.Point(10, 70);
            this.numLoopCnt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numLoopCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLoopCnt.Name = "numLoopCnt";
            this.numLoopCnt.Size = new System.Drawing.Size(121, 19);
            this.numLoopCnt.TabIndex = 1;
            this.numLoopCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLoopCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkFade
            // 
            this.chkFade.AutoSize = true;
            this.chkFade.Location = new System.Drawing.Point(10, 150);
            this.chkFade.Name = "chkFade";
            this.chkFade.Size = new System.Drawing.Size(58, 16);
            this.chkFade.TabIndex = 4;
            this.chkFade.Text = "フェード";
            this.chkFade.UseVisualStyleBackColor = true;
            // 
            // picCardImg
            // 
            this.picCardImg.Location = new System.Drawing.Point(150, 25);
            this.picCardImg.Name = "picCardImg";
            this.picCardImg.Size = new System.Drawing.Size(240, 240);
            this.picCardImg.TabIndex = 27;
            this.picCardImg.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "アニメーション一覧";
            // 
            // btnReadImage
            // 
            this.btnReadImage.Location = new System.Drawing.Point(10, 175);
            this.btnReadImage.Name = "btnReadImage";
            this.btnReadImage.Size = new System.Drawing.Size(55, 23);
            this.btnReadImage.TabIndex = 5;
            this.btnReadImage.Text = "読込";
            this.btnReadImage.UseVisualStyleBackColor = true;
            this.btnReadImage.Click += new System.EventHandler(this.ReadImage);
            // 
            // btnExportImage
            // 
            this.btnExportImage.Location = new System.Drawing.Point(76, 175);
            this.btnExportImage.Name = "btnExportImage";
            this.btnExportImage.Size = new System.Drawing.Size(55, 23);
            this.btnExportImage.TabIndex = 6;
            this.btnExportImage.Text = "取得";
            this.btnExportImage.UseVisualStyleBackColor = true;
            this.btnExportImage.Click += new System.EventHandler(this.ExportImage);
            // 
            // btnShiftLeft
            // 
            this.btnShiftLeft.Location = new System.Drawing.Point(10, 235);
            this.btnShiftLeft.Name = "btnShiftLeft";
            this.btnShiftLeft.Size = new System.Drawing.Size(23, 23);
            this.btnShiftLeft.TabIndex = 8;
            this.btnShiftLeft.Text = "＜";
            this.btnShiftLeft.UseVisualStyleBackColor = true;
            this.btnShiftLeft.Click += new System.EventHandler(this.MinusCard);
            // 
            // btnShiftRight
            // 
            this.btnShiftRight.Location = new System.Drawing.Point(108, 235);
            this.btnShiftRight.Name = "btnShiftRight";
            this.btnShiftRight.Size = new System.Drawing.Size(23, 23);
            this.btnShiftRight.TabIndex = 9;
            this.btnShiftRight.Text = "＞";
            this.btnShiftRight.UseVisualStyleBackColor = true;
            this.btnShiftRight.Click += new System.EventHandler(this.PlusCard);
            // 
            // txtCardShow
            // 
            this.txtCardShow.Location = new System.Drawing.Point(39, 235);
            this.txtCardShow.Name = "txtCardShow";
            this.txtCardShow.Size = new System.Drawing.Size(63, 23);
            this.txtCardShow.TabIndex = 33;
            this.txtCardShow.Text = "X / X";
            this.txtCardShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fdReadMap
            // 
            this.fdReadMap.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "読込方向";
            // 
            // cbReadDirection
            // 
            this.cbReadDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReadDirection.FormattingEnabled = true;
            this.cbReadDirection.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.cbReadDirection.Location = new System.Drawing.Point(76, 205);
            this.cbReadDirection.Name = "cbReadDirection";
            this.cbReadDirection.Size = new System.Drawing.Size(55, 20);
            this.cbReadDirection.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "表示拡大率";
            // 
            // numExtRate
            // 
            this.numExtRate.Location = new System.Drawing.Point(76, 265);
            this.numExtRate.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numExtRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExtRate.Name = "numExtRate";
            this.numExtRate.Size = new System.Drawing.Size(55, 19);
            this.numExtRate.TabIndex = 10;
            this.numExtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numExtRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExtRate.ValueChanged += new System.EventHandler(this.UpdateImage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "繰り返し回数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "加速度 / ファクタ(t^a)";
            // 
            // cbAnimType
            // 
            this.cbAnimType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimType.FormattingEnabled = true;
            this.cbAnimType.Items.AddRange(new object[] {
            "定速",
            "加速",
            "減速"});
            this.cbAnimType.Location = new System.Drawing.Point(10, 115);
            this.cbAnimType.Name = "cbAnimType";
            this.cbAnimType.Size = new System.Drawing.Size(55, 20);
            this.cbAnimType.TabIndex = 2;
            // 
            // fdSaveMap
            // 
            this.fdSaveMap.RestoreDirectory = true;
            // 
            // numFactor
            // 
            this.numFactor.DecimalPlaces = 2;
            this.numFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numFactor.Location = new System.Drawing.Point(76, 116);
            this.numFactor.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFactor.Name = "numFactor";
            this.numFactor.Size = new System.Drawing.Size(55, 19);
            this.numFactor.TabIndex = 3;
            this.numFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numFactor.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // MakeColorMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(397, 303);
            this.ControlBox = false;
            this.Controls.Add(this.numFactor);
            this.Controls.Add(this.cbAnimType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numExtRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbReadDirection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCardShow);
            this.Controls.Add(this.btnShiftRight);
            this.Controls.Add(this.btnShiftLeft);
            this.Controls.Add(this.btnExportImage);
            this.Controls.Add(this.btnReadImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picCardImg);
            this.Controls.Add(this.chkFade);
            this.Controls.Add(this.numLoopCnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTrigTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeColorMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeColorMap";
            ((System.ComponentModel.ISupportInitialize)(this.numTrigTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoopCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExtRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numTrigTime;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numLoopCnt;
        private System.Windows.Forms.CheckBox chkFade;
        private System.Windows.Forms.PictureBox picCardImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReadImage;
        private System.Windows.Forms.Button btnExportImage;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Label txtCardShow;
        private System.Windows.Forms.OpenFileDialog fdReadMap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbReadDirection;
        private System.Windows.Forms.Label label5;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numExtRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAnimType;
        private System.Windows.Forms.SaveFileDialog fdSaveMap;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numFactor;
    }
}