
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
            this.btnTL_ValCond = new System.Windows.Forms.Button();
            this.btnTL_TimerCond = new System.Windows.Forms.Button();
            this.btnTL_ValCtrl = new System.Windows.Forms.Button();
            this.btnTL_TimerCtrl = new System.Windows.Forms.Button();
            this.btnTL_SoundChange = new System.Windows.Forms.Button();
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
            this.btnUserTimer.Click += new System.EventHandler(this.StartModTimer);
            // 
            // btnTL_ValCond
            // 
            this.btnTL_ValCond.Location = new System.Drawing.Point(160, 10);
            this.btnTL_ValCond.Name = "btnTL_ValCond";
            this.btnTL_ValCond.Size = new System.Drawing.Size(140, 30);
            this.btnTL_ValCond.TabIndex = 0;
            this.btnTL_ValCond.Text = "[TL]変数演算";
            this.btnTL_ValCond.UseVisualStyleBackColor = true;
            this.btnTL_ValCond.Click += new System.EventHandler(this.StartModActValCtrl);
            // 
            // btnTL_TimerCond
            // 
            this.btnTL_TimerCond.Location = new System.Drawing.Point(160, 50);
            this.btnTL_TimerCond.Name = "btnTL_TimerCond";
            this.btnTL_TimerCond.Size = new System.Drawing.Size(140, 30);
            this.btnTL_TimerCond.TabIndex = 0;
            this.btnTL_TimerCond.Text = "[TL]タイマ動作・停止";
            this.btnTL_TimerCond.UseVisualStyleBackColor = true;
            this.btnTL_TimerCond.Click += new System.EventHandler(this.StartModVariable);
            // 
            // btnTL_ValCtrl
            // 
            this.btnTL_ValCtrl.Location = new System.Drawing.Point(160, 90);
            this.btnTL_ValCtrl.Name = "btnTL_ValCtrl";
            this.btnTL_ValCtrl.Size = new System.Drawing.Size(140, 30);
            this.btnTL_ValCtrl.TabIndex = 0;
            this.btnTL_ValCtrl.Text = "[TL]変数条件設定";
            this.btnTL_ValCtrl.UseVisualStyleBackColor = true;
            this.btnTL_ValCtrl.Click += new System.EventHandler(this.StartModActValCond);
            // 
            // btnTL_TimerCtrl
            // 
            this.btnTL_TimerCtrl.Location = new System.Drawing.Point(160, 130);
            this.btnTL_TimerCtrl.Name = "btnTL_TimerCtrl";
            this.btnTL_TimerCtrl.Size = new System.Drawing.Size(140, 30);
            this.btnTL_TimerCtrl.TabIndex = 0;
            this.btnTL_TimerCtrl.Text = "[TL]トリガ条件設定";
            this.btnTL_TimerCtrl.UseVisualStyleBackColor = true;
            this.btnTL_TimerCtrl.Click += new System.EventHandler(this.StartModActTimerCond);
            // 
            // btnTL_SoundChange
            // 
            this.btnTL_SoundChange.Location = new System.Drawing.Point(310, 10);
            this.btnTL_SoundChange.Name = "btnTL_SoundChange";
            this.btnTL_SoundChange.Size = new System.Drawing.Size(140, 30);
            this.btnTL_SoundChange.TabIndex = 0;
            this.btnTL_SoundChange.Text = "[TL]音データ鳴り分け設定";
            this.btnTL_SoundChange.UseVisualStyleBackColor = true;
            this.btnTL_SoundChange.Click += new System.EventHandler(this.StartModActChangeSound);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(549, 261);
            this.Controls.Add(this.btnSoundPlayData);
            this.Controls.Add(this.btnSoundID);
            this.Controls.Add(this.btnUserTimer);
            this.Controls.Add(this.btnTL_SoundChange);
            this.Controls.Add(this.btnTL_TimerCtrl);
            this.Controls.Add(this.btnTL_ValCtrl);
            this.Controls.Add(this.btnTL_TimerCond);
            this.Controls.Add(this.btnTL_ValCond);
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
        private System.Windows.Forms.Button btnTL_ValCond;
        private System.Windows.Forms.Button btnTL_TimerCond;
        private System.Windows.Forms.Button btnTL_ValCtrl;
        private System.Windows.Forms.Button btnTL_TimerCtrl;
        private System.Windows.Forms.Button btnTL_SoundChange;
    }
}

