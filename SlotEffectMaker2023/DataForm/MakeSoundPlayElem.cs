using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotEffectMaker2023.DataForm
{
    public partial class MakeSoundPlayElem : SlotMaker2022.UserControl.FormElemDecide
    {
        string defDataName;
        public MakeSoundPlayElem(Data.SoundPlayData sp)
        {
            InitializeComponent();
            if (sp == null) sp = new Data.SoundPlayData();
            var ed = Singleton.EffectDataManagerSingleton.GetInstance();
            cbUseTimer.Items.AddRange(ed.TimerList.GetTimerNameList());
            cbDefSound.Items.AddRange(ed.GetSoundIDNameList());
            numStartTime.Maximum = int.MaxValue;
            numStopTime.Maximum = int.MaxValue;
            defDataName = sp.ShifterName;
            // コントロール初期化
            tbPlayerName.Text = sp.ShifterName;
            if (ed.TimerList.CheckTimerExist(sp.UseTimerName)) cbUseTimer.SelectedItem = sp.UseTimerName;
            numStartTime.Value = sp.BeginTime;
            numStopTime.Value = sp.StopTime;
            if (ed.GetSoundID(sp.DefaultElemID) != null) cbDefSound.SelectedItem = sp.DefaultElemID;
        }
        public bool SetData(Data.SoundPlayData sp)
        {
            sp.ShifterName = tbPlayerName.Text;
            sp.UseTimerName = cbUseTimer.SelectedItem.ToString();
            sp.BeginTime = decimal.ToInt32(numStartTime.Value);
            sp.StopTime = decimal.ToInt32(numStopTime.Value);
            sp.DefaultElemID = cbDefSound.SelectedItem.ToString();
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbPlayerName.Text.Equals(string.Empty))
            {
                MessageBox.Show("プレイヤー名を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ed = Singleton.EffectDataManagerSingleton.GetInstance();
            if (ed.GetSoundPlayer(tbPlayerName.Text) != null && !defDataName.Equals(tbPlayerName.Text))
            {
                MessageBox.Show("プレイヤー名が他のデータと重複しています。\n他の名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbUseTimer.SelectedIndex < 0)
            {
                MessageBox.Show("使用タイマを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbDefSound.SelectedIndex < 0)
            {
                MessageBox.Show("デフォルト音源を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.BtnOK_Click(sender, e);
        }
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }
    }
}
