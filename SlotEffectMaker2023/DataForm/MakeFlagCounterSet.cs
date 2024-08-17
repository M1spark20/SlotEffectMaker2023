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
    public partial class MakeFlagCounterSet : SlotMaker2022.UserControl.FormElemDecide
    {
        private DataBuilder.FlagCounterCondBuilder builder;
        private List<Data.FlagCounterCond> switcher;

        public MakeFlagCounterSet(Data.FlagCounterSet fc)
        {
            InitializeComponent();

            var data = Singleton.EffectDataManagerSingleton.GetInstance();

            // cb初期化
            cbPlay.Items.AddRange(data.Timeline.GetAllCondName());
            cbPlay.Text = fc.CountCond;
            switcher = fc.elemData;
            CBChanged(null, null);

            // dgv初期化
            builder = new DataBuilder.FlagCounterCondBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, switcher);
        }
        public bool SetData(Data.FlagCounterSet fc)
        {
            fc.CountCond = cbPlay.Text;
            fc.elemData = switcher;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (cbPlay.SelectedIndex < 0)
            {
                MessageBox.Show("カウント条件を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void CBChanged(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance();
            string va = "カウント条件: " + baseData.Timeline.GetCondFromName(cbPlay.Text)?.usage;
            txtVarUsage.Text = va;
        }
    }
}
