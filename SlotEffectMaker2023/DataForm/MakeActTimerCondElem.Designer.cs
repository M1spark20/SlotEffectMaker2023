
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeActTimerCondElem
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
            this.tbUsage = new System.Windows.Forms.TextBox();
            this.tbDataName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShowAc = new System.Windows.Forms.DataGridView();
            this.btnSeekDnAc = new System.Windows.Forms.Button();
            this.btnSeekUpAc = new System.Windows.Forms.Button();
            this.btnDelAc = new System.Windows.Forms.Button();
            this.btnModAc = new System.Windows.Forms.Button();
            this.btnAddAc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUseTimer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numTrigTime = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTrigHold = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrigTime)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(362, 226);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 101;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.OK);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(282, 226);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 23);
            this.BtnCancel.TabIndex = 100;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // tbUsage
            // 
            this.tbUsage.Location = new System.Drawing.Point(10, 70);
            this.tbUsage.Name = "tbUsage";
            this.tbUsage.Size = new System.Drawing.Size(121, 19);
            this.tbUsage.TabIndex = 1;
            // 
            // tbDataName
            // 
            this.tbDataName.Location = new System.Drawing.Point(10, 25);
            this.tbDataName.Name = "tbDataName";
            this.tbDataName.Size = new System.Drawing.Size(121, 19);
            this.tbDataName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "用途";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "データ名";
            // 
            // dgvShowAc
            // 
            this.dgvShowAc.AllowUserToAddRows = false;
            this.dgvShowAc.AllowUserToDeleteRows = false;
            this.dgvShowAc.AllowUserToResizeColumns = false;
            this.dgvShowAc.AllowUserToResizeRows = false;
            this.dgvShowAc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShowAc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowAc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAc.Location = new System.Drawing.Point(137, 39);
            this.dgvShowAc.MultiSelect = false;
            this.dgvShowAc.Name = "dgvShowAc";
            this.dgvShowAc.ReadOnly = true;
            this.dgvShowAc.RowHeadersVisible = false;
            this.dgvShowAc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShowAc.RowTemplate.Height = 21;
            this.dgvShowAc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowAc.Size = new System.Drawing.Size(295, 181);
            this.dgvShowAc.TabIndex = 26;
            this.dgvShowAc.TabStop = false;
            // 
            // btnSeekDnAc
            // 
            this.btnSeekDnAc.Location = new System.Drawing.Point(328, 10);
            this.btnSeekDnAc.Name = "btnSeekDnAc";
            this.btnSeekDnAc.Size = new System.Drawing.Size(23, 23);
            this.btnSeekDnAc.TabIndex = 24;
            this.btnSeekDnAc.Text = "∨";
            this.btnSeekDnAc.UseVisualStyleBackColor = true;
            // 
            // btnSeekUpAc
            // 
            this.btnSeekUpAc.Location = new System.Drawing.Point(299, 10);
            this.btnSeekUpAc.Name = "btnSeekUpAc";
            this.btnSeekUpAc.Size = new System.Drawing.Size(23, 23);
            this.btnSeekUpAc.TabIndex = 23;
            this.btnSeekUpAc.Text = "∧";
            this.btnSeekUpAc.UseVisualStyleBackColor = true;
            // 
            // btnDelAc
            // 
            this.btnDelAc.Location = new System.Drawing.Point(357, 10);
            this.btnDelAc.Name = "btnDelAc";
            this.btnDelAc.Size = new System.Drawing.Size(75, 23);
            this.btnDelAc.TabIndex = 25;
            this.btnDelAc.Text = "Action削除";
            this.btnDelAc.UseVisualStyleBackColor = true;
            // 
            // btnModAc
            // 
            this.btnModAc.Location = new System.Drawing.Point(218, 10);
            this.btnModAc.Name = "btnModAc";
            this.btnModAc.Size = new System.Drawing.Size(75, 23);
            this.btnModAc.TabIndex = 22;
            this.btnModAc.Text = "Action編集";
            this.btnModAc.UseVisualStyleBackColor = true;
            // 
            // btnAddAc
            // 
            this.btnAddAc.Location = new System.Drawing.Point(137, 10);
            this.btnAddAc.Name = "btnAddAc";
            this.btnAddAc.Size = new System.Drawing.Size(75, 23);
            this.btnAddAc.TabIndex = 21;
            this.btnAddAc.Text = "Action追加";
            this.btnAddAc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "使用タイマ";
            // 
            // cbUseTimer
            // 
            this.cbUseTimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUseTimer.FormattingEnabled = true;
            this.cbUseTimer.Location = new System.Drawing.Point(10, 115);
            this.cbUseTimer.Name = "cbUseTimer";
            this.cbUseTimer.Size = new System.Drawing.Size(121, 20);
            this.cbUseTimer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "トリガ時間";
            // 
            // numTrigTime
            // 
            this.numTrigTime.Location = new System.Drawing.Point(10, 161);
            this.numTrigTime.Name = "numTrigTime";
            this.numTrigTime.Size = new System.Drawing.Size(95, 19);
            this.numTrigTime.TabIndex = 3;
            this.numTrigTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "ms";
            // 
            // chkTrigHold
            // 
            this.chkTrigHold.AutoSize = true;
            this.chkTrigHold.Location = new System.Drawing.Point(10, 195);
            this.chkTrigHold.Name = "chkTrigHold";
            this.chkTrigHold.Size = new System.Drawing.Size(73, 16);
            this.chkTrigHold.TabIndex = 4;
            this.chkTrigHold.Text = "トリガ保持";
            this.chkTrigHold.UseVisualStyleBackColor = true;
            // 
            // MakeActTimerCondElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(443, 259);
            this.ControlBox = false;
            this.Controls.Add(this.chkTrigHold);
            this.Controls.Add(this.numTrigTime);
            this.Controls.Add(this.cbUseTimer);
            this.Controls.Add(this.dgvShowAc);
            this.Controls.Add(this.btnSeekDnAc);
            this.Controls.Add(this.btnSeekUpAc);
            this.Controls.Add(this.btnDelAc);
            this.Controls.Add(this.btnModAc);
            this.Controls.Add(this.btnAddAc);
            this.Controls.Add(this.tbUsage);
            this.Controls.Add(this.tbDataName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeActTimerCondElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeActTimerCond";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrigTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox tbUsage;
        private System.Windows.Forms.TextBox tbDataName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.DataGridView dgvShowAc;
        protected System.Windows.Forms.Button btnSeekDnAc;
        protected System.Windows.Forms.Button btnSeekUpAc;
        protected System.Windows.Forms.Button btnDelAc;
        protected System.Windows.Forms.Button btnModAc;
        protected System.Windows.Forms.Button btnAddAc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUseTimer;
        private System.Windows.Forms.Label label4;
        private SlotMaker2022.UserControl.NumericUpDown_AutoSelect numTrigTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTrigHold;
    }
}