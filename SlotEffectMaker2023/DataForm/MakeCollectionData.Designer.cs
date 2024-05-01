
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeCollectionData
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
            this.btnSeekDn = new System.Windows.Forms.Button();
            this.btnSeekUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.cbJudge = new System.Windows.Forms.ComboBox();
            this.cbHazure = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAiming = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "判定条件変数";
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(365, 226);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(70, 23);
            this.BtnOK.TabIndex = 21;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.OK);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(285, 226);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(70, 23);
            this.BtnCancel.TabIndex = 20;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "はずれ条件変数";
            // 
            // btnSeekDn
            // 
            this.btnSeekDn.Location = new System.Drawing.Point(331, 10);
            this.btnSeekDn.Name = "btnSeekDn";
            this.btnSeekDn.Size = new System.Drawing.Size(23, 23);
            this.btnSeekDn.TabIndex = 13;
            this.btnSeekDn.Text = "∨";
            this.btnSeekDn.UseVisualStyleBackColor = true;
            // 
            // btnSeekUp
            // 
            this.btnSeekUp.Location = new System.Drawing.Point(302, 10);
            this.btnSeekUp.Name = "btnSeekUp";
            this.btnSeekUp.Size = new System.Drawing.Size(23, 23);
            this.btnSeekUp.TabIndex = 12;
            this.btnSeekUp.Text = "∧";
            this.btnSeekUp.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(360, 10);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "データ削除";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(221, 10);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 11;
            this.btnMod.Text = "データ編集";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(140, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "データ追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToResizeColumns = false;
            this.dgvShow.AllowUserToResizeRows = false;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(140, 39);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShow.RowTemplate.Height = 21;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(295, 181);
            this.dgvShow.TabIndex = 15;
            this.dgvShow.TabStop = false;
            // 
            // cbJudge
            // 
            this.cbJudge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJudge.FormattingEnabled = true;
            this.cbJudge.Location = new System.Drawing.Point(10, 25);
            this.cbJudge.Name = "cbJudge";
            this.cbJudge.Size = new System.Drawing.Size(121, 20);
            this.cbJudge.TabIndex = 0;
            // 
            // cbHazure
            // 
            this.cbHazure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHazure.FormattingEnabled = true;
            this.cbHazure.Location = new System.Drawing.Point(10, 70);
            this.cbHazure.Name = "cbHazure";
            this.cbHazure.Size = new System.Drawing.Size(121, 20);
            this.cbHazure.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "目押しはずれ条件変数";
            // 
            // cbAiming
            // 
            this.cbAiming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAiming.FormattingEnabled = true;
            this.cbAiming.Location = new System.Drawing.Point(10, 115);
            this.cbAiming.Name = "cbAiming";
            this.cbAiming.Size = new System.Drawing.Size(121, 20);
            this.cbAiming.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "※判定条件の前提として\r\n　gameMode = 0がある。";
            // 
            // MakeCollectionData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(444, 255);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAiming);
            this.Controls.Add(this.cbHazure);
            this.Controls.Add(this.cbJudge);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnSeekDn);
            this.Controls.Add(this.btnSeekUp);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeCollectionData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeActMultiVarSetElem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnSeekDn;
        protected System.Windows.Forms.Button btnSeekUp;
        protected System.Windows.Forms.Button btnDel;
        protected System.Windows.Forms.Button btnMod;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.ComboBox cbJudge;
        private System.Windows.Forms.ComboBox cbHazure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAiming;
        private System.Windows.Forms.Label label4;
    }
}