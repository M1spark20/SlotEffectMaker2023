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
    public partial class MakeActTimerCondElem : SlotMaker2022.UserControl.FormElemDecide
    {
        private static string dataNameHead = "ActTC";
        string defDataName;
        DataBuilder.ActCondTrigBuilder builderAction;

        public MakeActTimerCondElem(Data.EfActTimerCond tc)
        {
            InitializeComponent();
            tbDataName.Text = dataNameHead;
            if (tc == null) tc = new Data.EfActTimerCond();
            else tbDataName.Text = tc.dataName;
            // コントロール初期化
            defDataName = tc.dataName;
            tbUsage.Text = tc.usage;
            var tList = Singleton.EffectDataManagerSingleton.GetInstance().TimerList;
            cbUseTimer.Items.AddRange(tList.GetTimerNameList());
            cbUseTimer.Text = tc.cond.timerName;
            numTrigTime.Maximum = int.MaxValue;
            numTrigTime.Value = tc.cond.elapsed;
            chkTrigHold.Checked = tc.cond.trigHold;
            builderAction = new DataBuilder.ActCondTrigBuilder(btnAddAc, btnModAc, btnDelAc, btnSeekUpAc, btnSeekDnAc, dgvShowAc, tc.action, true);
        }
        public bool SetData(Data.EfActTimerCond tc)
        {
            tc.dataName = tbDataName.Text;
            tc.usage = tbUsage.Text;
            tc.action = builderAction.GetData();
            tc.cond.timerName = cbUseTimer.Text;
            tc.cond.elapsed = decimal.ToInt32(numTrigTime.Value);
            tc.cond.trigHold = chkTrigHold.Checked;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            if (!tbDataName.Text.StartsWith(dataNameHead))
            {
                MessageBox.Show("データ名は" + dataNameHead + "から始めてください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (baseData.IsActNameExist(tbDataName.Text) && !defDataName.Equals(tbDataName.Text))
            {
                MessageBox.Show("データ名が他のデータと重複しています。\n他の名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.BtnOK_Click(sender, e);
        }

        private void Cancel(object sender, EventArgs e)
        {
            BtnCancel_Click(sender, e);
        }
        private void OK(object sender, EventArgs e)
        {
            BtnOK_Click(sender, e);
        }
    }
}
