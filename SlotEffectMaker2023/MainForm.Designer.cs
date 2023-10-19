
namespace SlotEffectMaker2023
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnValSet = new System.Windows.Forms.Button();
            this.btnSoundID = new System.Windows.Forms.Button();
            this.btnSoundPlayData = new System.Windows.Forms.Button();
            this.btnUserTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValSet
            // 
            this.btnValSet.Location = new System.Drawing.Point(10, 10);
            this.btnValSet.Name = "btnValSet";
            this.btnValSet.Size = new System.Drawing.Size(140, 30);
            this.btnValSet.TabIndex = 0;
            this.btnValSet.Text = "ユーザ変数設定";
            this.btnValSet.UseVisualStyleBackColor = true;
            this.btnValSet.Click += new System.EventHandler(this.StartModVariable);
            // 
            // btnSoundID
            // 
            this.btnSoundID.Location = new System.Drawing.Point(10, 90);
            this.btnSoundID.Name = "btnSoundID";
            this.btnSoundID.Size = new System.Drawing.Size(140, 30);
            this.btnSoundID.TabIndex = 2;
            this.btnSoundID.Text = "音源設定";
            this.btnSoundID.UseVisualStyleBackColor = true;
            this.btnSoundID.Click += new System.EventHandler(this.StartModSoundID);
            // 
            // btnSoundPlayData
            // 
            this.btnSoundPlayData.Location = new System.Drawing.Point(10, 130);
            this.btnSoundPlayData.Name = "btnSoundPlayData";
            this.btnSoundPlayData.Size = new System.Drawing.Size(140, 30);
            this.btnSoundPlayData.TabIndex = 3;
            this.btnSoundPlayData.Text = "音再生タイミング設定";
            this.btnSoundPlayData.UseVisualStyleBackColor = true;
            this.btnSoundPlayData.Click += new System.EventHandler(this.StartModSoundPlay);
            // 
            // btnUserTimer
            // 
            this.btnUserTimer.Location = new System.Drawing.Point(10, 50);
            this.btnUserTimer.Name = "btnUserTimer";
            this.btnUserTimer.Size = new System.Drawing.Size(140, 30);
            this.btnUserTimer.TabIndex = 1;
            this.btnUserTimer.Text = "ユーザタイマ設定";
            this.btnUserTimer.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.btnSoundPlayData);
            this.Controls.Add(this.btnSoundID);
            this.Controls.Add(this.btnUserTimer);
            this.Controls.Add(this.btnValSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValSet;
        private System.Windows.Forms.Button btnSoundID;
        private System.Windows.Forms.Button btnSoundPlayData;
        private System.Windows.Forms.Button btnUserTimer;
    }
}

