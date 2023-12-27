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
    public partial class MakeEfVarCtrlElem : SlotMaker2022.UserControl.FormElemDecide
    {
        private static string dataNameHead = "ActVO";
        string defDataName;
        DataBuilder.EfVarOPBuilder builderAction;

        public MakeEfVarCtrlElem(Data.EfActCtrlVal cv)
        {
            InitializeComponent();
            tbDataName.Text = dataNameHead;
            if (cv == null) cv = new Data.EfActCtrlVal();
            else tbDataName.Text = cv.dataName;
            // コントロール初期化
            defDataName = cv.dataName;
            tbUsage.Text = cv.usage;
            var tList = Singleton.EffectDataManagerSingleton.GetInstance().VarList;
            cbVarExport.Items.AddRange(tList.GetUserVariableNameList());
            cbVarExport.Text = cv.valInputFor;
            builderAction = new DataBuilder.EfVarOPBuilder(btnAddAc, btnModAc, btnDelAc, btnSeekUpAc, btnSeekDnAc, dgvShowAc, cv.operands);
        }
        public bool SetData(Data.EfActCtrlVal cv)
        {
            cv.dataName = tbDataName.Text;
            cv.usage = tbUsage.Text;
            cv.valInputFor = cbVarExport.Text;
            cv.operands = builderAction.GetData();
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
            if (cbVarExport.SelectedIndex < 0)
            {
                MessageBox.Show("演算結果代入先変数を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (builderAction.GetData().Count <= 0)
            {
                MessageBox.Show("演算を1つ以上設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
