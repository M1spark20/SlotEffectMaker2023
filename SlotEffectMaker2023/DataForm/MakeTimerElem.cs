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
    public partial class MakeTimerElem : SlotMaker2022.UserControl.FormElemDecide
    {
        string defDataName;
        public MakeTimerElem(Data.UserTimerData td)
        {
            InitializeComponent();
            if (td == null) td = new Data.UserTimerData();
            defDataName = td.UserTimerName;
            // コントロール初期化
            tbDataName.Text = td.UserTimerName;
            chkStore.Checked = td.StoreActivation;
            tbUsage.Text = td.Usage;
        }
        public bool SetData(Data.UserTimerData td)
        {
            td.UserTimerName = tbDataName.Text;
            td.StoreActivation = chkStore.Checked;
            td.Usage = tbUsage.Text;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbDataName.Text.Equals(string.Empty))
            {
                MessageBox.Show("タイマ名を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!tbDataName.Text.StartsWith("$"))
            {
                MessageBox.Show("タイマ名は$から始めてください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance().VarList;
            if (baseData.GetData(tbDataName.Text) != null && !defDataName.Equals(tbDataName.Text))
            {
                MessageBox.Show("タイマ名が他のデータと重複しています。\n他の名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
