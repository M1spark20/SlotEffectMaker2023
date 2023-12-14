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
    public partial class MakeEfCondTrig : SlotMaker2022.UserControl.FormElemDecide
    {
        public MakeEfCondTrig(Data.EfCondTrig ct)
        {
            InitializeComponent();
            if (ct == null) ct = new Data.EfCondTrig();
            // コントロール初期化
            var acts = Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            var itemList = acts.GetAllActName();
            cbActName.Items.AddRange(itemList);
            cbActName.Text = ct.actName;
            rbTrue.Checked = ct.cdEnable;
            rbFalse.Checked = !ct.cdEnable;
        }
        public bool SetData(Data.EfCondTrig ct)
        {
            ct.actName = cbActName.Text;
            ct.cdEnable = rbTrue.Checked;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (cbActName.SelectedIndex < 0)
            {
                MessageBox.Show("アクションを設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
