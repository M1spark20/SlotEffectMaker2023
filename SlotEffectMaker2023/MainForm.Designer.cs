
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
            this.btnTL_RandData = new System.Windows.Forms.Button();
            this.btnTL_MultiVarSet = new System.Windows.Forms.Button();
            this.btnMakeColorMap = new System.Windows.Forms.Button();
            this.btnMakeColorMapPlay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHistoryConf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMakeGameAchievement = new System.Windows.Forms.Button();
            this.btnSetFlagCounter = new System.Windows.Forms.Button();
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
            this.btnTL_ValCond.TabIndex = 10;
            this.btnTL_ValCond.Text = "[TL]変数演算";
            this.btnTL_ValCond.UseVisualStyleBackColor = true;
            this.btnTL_ValCond.Click += new System.EventHandler(this.StartModActValCtrl);
            // 
            // btnTL_TimerCond
            // 
            this.btnTL_TimerCond.Location = new System.Drawing.Point(160, 50);
            this.btnTL_TimerCond.Name = "btnTL_TimerCond";
            this.btnTL_TimerCond.Size = new System.Drawing.Size(140, 30);
            this.btnTL_TimerCond.TabIndex = 11;
            this.btnTL_TimerCond.Text = "[TL]タイマ動作・停止";
            this.btnTL_TimerCond.UseVisualStyleBackColor = true;
            this.btnTL_TimerCond.Click += new System.EventHandler(this.StartModActCtrlTimer);
            // 
            // btnTL_ValCtrl
            // 
            this.btnTL_ValCtrl.Location = new System.Drawing.Point(160, 90);
            this.btnTL_ValCtrl.Name = "btnTL_ValCtrl";
            this.btnTL_ValCtrl.Size = new System.Drawing.Size(140, 30);
            this.btnTL_ValCtrl.TabIndex = 12;
            this.btnTL_ValCtrl.Text = "[TL]変数条件設定";
            this.btnTL_ValCtrl.UseVisualStyleBackColor = true;
            this.btnTL_ValCtrl.Click += new System.EventHandler(this.StartModActValCond);
            // 
            // btnTL_TimerCtrl
            // 
            this.btnTL_TimerCtrl.Location = new System.Drawing.Point(160, 130);
            this.btnTL_TimerCtrl.Name = "btnTL_TimerCtrl";
            this.btnTL_TimerCtrl.Size = new System.Drawing.Size(140, 30);
            this.btnTL_TimerCtrl.TabIndex = 13;
            this.btnTL_TimerCtrl.Text = "[TL]トリガ条件設定";
            this.btnTL_TimerCtrl.UseVisualStyleBackColor = true;
            this.btnTL_TimerCtrl.Click += new System.EventHandler(this.StartModActTimerCond);
            // 
            // btnTL_SoundChange
            // 
            this.btnTL_SoundChange.Location = new System.Drawing.Point(310, 10);
            this.btnTL_SoundChange.Name = "btnTL_SoundChange";
            this.btnTL_SoundChange.Size = new System.Drawing.Size(140, 30);
            this.btnTL_SoundChange.TabIndex = 20;
            this.btnTL_SoundChange.Text = "[TL]音データ鳴り分け設定";
            this.btnTL_SoundChange.UseVisualStyleBackColor = true;
            this.btnTL_SoundChange.Click += new System.EventHandler(this.StartModActChangeSound);
            // 
            // btnTL_RandData
            // 
            this.btnTL_RandData.Location = new System.Drawing.Point(310, 50);
            this.btnTL_RandData.Name = "btnTL_RandData";
            this.btnTL_RandData.Size = new System.Drawing.Size(140, 30);
            this.btnTL_RandData.TabIndex = 21;
            this.btnTL_RandData.Text = "[TL]乱数抽選設定";
            this.btnTL_RandData.UseVisualStyleBackColor = true;
            this.btnTL_RandData.Click += new System.EventHandler(this.StartModActRandData);
            // 
            // btnTL_MultiVarSet
            // 
            this.btnTL_MultiVarSet.Location = new System.Drawing.Point(310, 90);
            this.btnTL_MultiVarSet.Name = "btnTL_MultiVarSet";
            this.btnTL_MultiVarSet.Size = new System.Drawing.Size(140, 30);
            this.btnTL_MultiVarSet.TabIndex = 22;
            this.btnTL_MultiVarSet.Text = "[TL]複数変数代入設定";
            this.btnTL_MultiVarSet.UseVisualStyleBackColor = true;
            this.btnTL_MultiVarSet.Click += new System.EventHandler(this.StartModActMultiVarSet);
            // 
            // btnMakeColorMap
            // 
            this.btnMakeColorMap.Location = new System.Drawing.Point(10, 170);
            this.btnMakeColorMap.Name = "btnMakeColorMap";
            this.btnMakeColorMap.Size = new System.Drawing.Size(140, 30);
            this.btnMakeColorMap.TabIndex = 4;
            this.btnMakeColorMap.Text = "カラーマップ設定";
            this.btnMakeColorMap.UseVisualStyleBackColor = true;
            this.btnMakeColorMap.Click += new System.EventHandler(this.StartModColorMapData);
            // 
            // btnMakeColorMapPlay
            // 
            this.btnMakeColorMapPlay.Location = new System.Drawing.Point(10, 210);
            this.btnMakeColorMapPlay.Name = "btnMakeColorMapPlay";
            this.btnMakeColorMapPlay.Size = new System.Drawing.Size(140, 30);
            this.btnMakeColorMapPlay.TabIndex = 5;
            this.btnMakeColorMapPlay.Text = "MAPプレイヤー設定";
            this.btnMakeColorMapPlay.UseVisualStyleBackColor = true;
            this.btnMakeColorMapPlay.Click += new System.EventHandler(this.StartModColorMapShifter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "[TL]カラーマップ変更設定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartModActMapChange);
            // 
            // btnHistoryConf
            // 
            this.btnHistoryConf.Location = new System.Drawing.Point(10, 250);
            this.btnHistoryConf.Name = "btnHistoryConf";
            this.btnHistoryConf.Size = new System.Drawing.Size(140, 30);
            this.btnHistoryConf.TabIndex = 24;
            this.btnHistoryConf.Text = "データ履歴設定";
            this.btnHistoryConf.UseVisualStyleBackColor = true;
            this.btnHistoryConf.Click += new System.EventHandler(this.StartModHistoryConfig);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 24;
            this.button2.Text = "リーチ目コレクション設定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StartModCollection);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "音再生タイミング設定:\r\nPlayerNameにBGMを入れると音量がBGM準拠となる";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "[Note]";
            // 
            // btnMakeGameAchievement
            // 
            this.btnMakeGameAchievement.Location = new System.Drawing.Point(160, 170);
            this.btnMakeGameAchievement.Name = "btnMakeGameAchievement";
            this.btnMakeGameAchievement.Size = new System.Drawing.Size(140, 30);
            this.btnMakeGameAchievement.TabIndex = 13;
            this.btnMakeGameAchievement.Text = "Steam用実績定義";
            this.btnMakeGameAchievement.UseVisualStyleBackColor = true;
            this.btnMakeGameAchievement.Click += new System.EventHandler(this.StartModGameAchievement);
            // 
            // btnSetFlagCounter
            // 
            this.btnSetFlagCounter.Location = new System.Drawing.Point(160, 210);
            this.btnSetFlagCounter.Name = "btnSetFlagCounter";
            this.btnSetFlagCounter.Size = new System.Drawing.Size(140, 30);
            this.btnSetFlagCounter.TabIndex = 13;
            this.btnSetFlagCounter.Text = "フラグ成立回数カウント";
            this.btnSetFlagCounter.UseVisualStyleBackColor = true;
            this.btnSetFlagCounter.Click += new System.EventHandler(this.StartModFlagCount);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(549, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHistoryConf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMakeColorMapPlay);
            this.Controls.Add(this.btnMakeColorMap);
            this.Controls.Add(this.btnTL_MultiVarSet);
            this.Controls.Add(this.btnTL_RandData);
            this.Controls.Add(this.btnSoundPlayData);
            this.Controls.Add(this.btnSoundID);
            this.Controls.Add(this.btnUserTimer);
            this.Controls.Add(this.btnTL_SoundChange);
            this.Controls.Add(this.btnSetFlagCounter);
            this.Controls.Add(this.btnMakeGameAchievement);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnTL_RandData;
        private System.Windows.Forms.Button btnTL_MultiVarSet;
        private System.Windows.Forms.Button btnMakeColorMap;
        private System.Windows.Forms.Button btnMakeColorMapPlay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHistoryConf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMakeGameAchievement;
        private System.Windows.Forms.Button btnSetFlagCounter;
    }
}

