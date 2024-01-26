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
    public partial class MakeDataShifterElem : SlotMaker2022.UserControl.FormElemDecide
    {
        string defDataName;
        public MakeDataShifterElem(Data.DataShifterBase ds, string plName, string defName, string[] cbDataList)
        {
            InitializeComponent();
            if (ds == null) ds = new Data.SoundPlayData();
            var ed = Singleton.EffectDataManagerSingleton.GetInstance();
            cbUseTimer.Items.AddRange(ed.TimerList.GetTimerNameList());
            cbDefElem.Items.AddRange(cbDataList);
            numStartTime.Maximum = int.MaxValue;
            numStopTime.Maximum = int.MaxValue;
            defDataName = ds.ShifterName;
            // コントロール初期化
            txtPlName.Text = plName;
            txtDefName.Text = defName;
            tbPlayerName.Text = ds.ShifterName;
            cbUseTimer.Text = ds.UseTimerName;
            numStartTime.Value = ds.BeginTime;
            numStopTime.Value = ds.StopTime;
            cbDefElem.Text = ds.DefaultElemID;
        }
        public bool SetData(Data.DataShifterBase ds)
        {
            ds.ShifterName = tbPlayerName.Text;
            ds.UseTimerName = cbUseTimer.SelectedItem.ToString();
            ds.BeginTime = decimal.ToInt32(numStartTime.Value);
            ds.StopTime = decimal.ToInt32(numStopTime.Value);
            ds.DefaultElemID = cbDefElem.SelectedItem.ToString();
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbPlayerName.Text.Equals(string.Empty))
            {
                MessageBox.Show(txtPlName.Text + "を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var ed = Singleton.EffectDataManagerSingleton.GetInstance();
            if (ed.GetSoundPlayer(tbPlayerName.Text) != null && !defDataName.Equals(tbPlayerName.Text))
            {
                MessageBox.Show(txtPlName.Text + "が他のデータと重複しています。\n他の名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbUseTimer.SelectedIndex < 0)
            {
                MessageBox.Show("使用タイマを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbDefElem.SelectedIndex < 0)
            {
                MessageBox.Show(txtDefName.Text + "を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
