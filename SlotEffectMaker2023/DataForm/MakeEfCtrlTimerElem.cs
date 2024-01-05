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
    public partial class MakeEfCtrlTimerElem : SlotMaker2022.UserControl.FormElemDecide
    {
        private static string dataNameHead = "ActCT";
        string defDataName;

        public MakeEfCtrlTimerElem(Data.EfActCtrlTimer ct)
        {
            InitializeComponent();
            tbDataName.Text = dataNameHead;
            if (ct == null) ct = new Data.EfActCtrlTimer();
            else tbDataName.Text = ct.dataName;
            // コントロール初期化
            defDataName = ct.dataName;
            tbUsage.Text = ct.usage;
            rbStart.Checked = ct.setActivate;
            rbStop.Checked = !ct.setActivate;
            chkForceReset.Checked = ct.forceReset;
            var acts = Singleton.EffectDataManagerSingleton.GetInstance().TimerList;
            cbTimerName.Items.AddRange(acts.GetTimerNameList());
            cbTimerName.Text = ct.defName;
            CheckedChanged(null, null);
        }
        public bool SetData(Data.EfActCtrlTimer ct)
        {
            ct.dataName = tbDataName.Text;
            ct.usage = tbUsage.Text;
            ct.setActivate = rbStart.Checked;
            ct.forceReset = rbStart.Checked && chkForceReset.Checked;
            ct.defName = cbTimerName.Text;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance().Timeline;

            if (cbTimerName.SelectedIndex < 0)
            {
                MessageBox.Show("タイマ制御先を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            chkForceReset.Enabled = rbStart.Checked;
        }
    }
}
