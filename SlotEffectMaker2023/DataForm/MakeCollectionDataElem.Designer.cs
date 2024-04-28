
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeCollectionDataElem
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
            this.txt1 = new System.Windows.Forms.Label();
            this.numComaID = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.txtLv = new System.Windows.Forms.Label();
            this.numLevel = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.txt2 = new System.Windows.Forms.Label();
            this.cbPtn = new System.Windows.Forms.ComboBox();
            this.txt3 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.Label();
            this.numSymbolID = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.txtSymbol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numComaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolID)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.Location = new System.Drawing.Point(311, 219);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 1011;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(231, 219);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 23);
            this.BtnCancel.TabIndex = 1010;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(100, 10);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(68, 12);
            this.txt1.TabIndex = 22;
            this.txt1.Text = "左リール定義";
            // 
            // numComaID
            // 
            this.numComaID.Location = new System.Drawing.Point(100, 61);
            this.numComaID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numComaID.Name = "numComaID";
            this.numComaID.Size = new System.Drawing.Size(80, 19);
            this.numComaID.TabIndex = 2;
            this.numComaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLv
            // 
            this.txtLv.AutoSize = true;
            this.txtLv.Location = new System.Drawing.Point(10, 225);
            this.txtLv.Name = "txtLv";
            this.txtLv.Size = new System.Drawing.Size(55, 12);
            this.txtLv.TabIndex = 36;
            this.txtLv.Text = "難易度Lv.";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(76, 221);
            this.numLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(55, 19);
            this.numLevel.TabIndex = 1000;
            this.numLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(10, 35);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(53, 12);
            this.txt2.TabIndex = 24;
            this.txt2.Text = "定義種別";
            // 
            // cbPtn
            // 
            this.cbPtn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPtn.FormattingEnabled = true;
            this.cbPtn.Location = new System.Drawing.Point(100, 31);
            this.cbPtn.Name = "cbPtn";
            this.cbPtn.Size = new System.Drawing.Size(80, 20);
            this.cbPtn.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Location = new System.Drawing.Point(10, 64);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(57, 12);
            this.txt3.TabIndex = 24;
            this.txt3.Text = "下段コマID";
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.Location = new System.Drawing.Point(10, 94);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(55, 12);
            this.txt4.TabIndex = 24;
            this.txt4.Text = "シンボルID";
            // 
            // numSymbolID
            // 
            this.numSymbolID.Location = new System.Drawing.Point(100, 171);
            this.numSymbolID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSymbolID.Name = "numSymbolID";
            this.numSymbolID.Size = new System.Drawing.Size(80, 19);
            this.numSymbolID.TabIndex = 3;
            this.numSymbolID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSymbol
            // 
            this.txtSymbol.AutoSize = true;
            this.txtSymbol.Location = new System.Drawing.Point(98, 193);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(65, 12);
            this.txtSymbol.TabIndex = 24;
            this.txtSymbol.Text = "0123456789";
            // 
            // MakeCollectionDataElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(387, 251);
            this.ControlBox = false;
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.txtLv);
            this.Controls.Add(this.cbPtn);
            this.Controls.Add(this.numSymbolID);
            this.Controls.Add(this.numComaID);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeCollectionDataElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeCollectionDataElem";
            ((System.ComponentModel.ISupportInitialize)(this.numComaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSymbolID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label txt1;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numComaID;
        private System.Windows.Forms.Label txtLv;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numLevel;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.ComboBox cbPtn;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Label txt4;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numSymbolID;
        private System.Windows.Forms.Label txtSymbol;
    }
}