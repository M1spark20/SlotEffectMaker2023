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
    public partial class MakeActValCondElem : SlotMaker2022.UserControl.FormElemDecide
    {
        private static string dataNameHead = "ActVC";
        string defDataName;
        DataBuilder.ActValCondBuilderCondAND builderAND;
        DataBuilder.ActCondTrigBuilder builderAction;

        public MakeActValCondElem(Data.EfActValCond ac)
        {
            InitializeComponent();
            tbDataName.Text = dataNameHead;
            if (ac == null) ac = new Data.EfActValCond();
            else tbDataName.Text = ac.dataName;
            // コントロール初期化
            defDataName = ac.dataName;
            tbUsage.Text = ac.usage;

            builderAND = new DataBuilder.ActValCondBuilderCondAND(btnAddCd, btnModCd, btnDelCd, btnSeekUpCd, btnSeekDnCd, dgvShowCd, ac.conds);
            builderAction = new DataBuilder.ActCondTrigBuilder(btnAddAc, btnModAc, btnDelAc, btnSeekUpAc, btnSeekDnAc, dgvShowAc, ac.actionList);
        }
        public bool SetData(Data.EfActValCond ac)
        {
            ac.dataName = tbDataName.Text;
            ac.usage = tbUsage.Text;
            ac.conds = builderAND.GetData();
            ac.actionList = builderAction.GetData();
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
