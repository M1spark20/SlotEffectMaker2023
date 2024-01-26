
namespace SlotEffectMaker2023.DataForm
{
    partial class MakeActChangeMapElem
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
            this.cbPlay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVar = new System.Windows.Forms.ComboBox();
            this.btnSeekDn = new System.Windows.Forms.Button();
            this.btnSeekUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDataName = new System.Windows.Forms.TextBox();
            this.tbUsage = new System.Windows.Forms.TextBox();
            this.txtVarUsage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "データ名";
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
            // cbPlay
            // 
            this.cbPlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlay.FormattingEnabled = true;
            this.cbPlay.ItemHeight = 12;
            this.cbPlay.Location = new System.Drawing.Point(10, 115);
            this.cbPlay.Name = "cbPlay";
            this.cbPlay.Size = new System.Drawing.Size(121, 20);
            this.cbPlay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "用途";
            // 
            // cbVar
            // 
            this.cbVar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVar.FormattingEnabled = true;
            this.cbVar.Location = new System.Drawing.Point(10, 160);
            this.cbVar.Name = "cbVar";
            this.cbVar.Size = new System.Drawing.Size(121, 20);
            this.cbVar.TabIndex = 3;
            this.cbVar.SelectedIndexChanged += new System.EventHandler(this.CBChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "制御プレイヤー";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "制御変数";
            // 
            // tbDataName
            // 
            this.tbDataName.Location = new System.Drawing.Point(10, 25);
            this.tbDataName.Name = "tbDataName";
            this.tbDataName.Size = new System.Drawing.Size(121, 19);
            this.tbDataName.TabIndex = 0;
            // 
            // tbUsage
            // 
            this.tbUsage.Location = new System.Drawing.Point(10, 70);
            this.tbUsage.Name = "tbUsage";
            this.tbUsage.Size = new System.Drawing.Size(121, 19);
            this.tbUsage.TabIndex = 1;
            // 
            // txtVarUsage
            // 
            this.txtVarUsage.AutoSize = true;
            this.txtVarUsage.Location = new System.Drawing.Point(10, 255);
            this.txtVarUsage.Name = "txtVarUsage";
            this.txtVarUsage.Size = new System.Drawing.Size(59, 12);
            this.txtVarUsage.TabIndex = 23;
            this.txtVarUsage.Text = "制御変数: ";
            // 
            // MakeActChangeMapElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(444, 272);
            this.ControlBox = false;
            this.Controls.Add(this.txtVarUsage);
            this.Controls.Add(this.tbUsage);
            this.Controls.Add(this.tbDataName);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.btnSeekDn);
            this.Controls.Add(this.btnSeekUp);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbVar);
            this.Controls.Add(this.cbPlay);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MakeActChangeMapElem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeActChangeSound";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox cbPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVar;
        protected System.Windows.Forms.Button btnSeekDn;
        protected System.Windows.Forms.Button btnSeekUp;
        protected System.Windows.Forms.Button btnDel;
        protected System.Windows.Forms.Button btnMod;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDataName;
        private System.Windows.Forms.TextBox tbUsage;
        private System.Windows.Forms.Label txtVarUsage;
    }
}