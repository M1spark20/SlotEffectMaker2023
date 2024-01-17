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
    public partial class MakeEfRandValElem : SlotMaker2022.UserControl.FormElemDecide
    {
        private static string dataNameHead = "ActRd";
        string defDataName;
        DataBuilder.ActRandTableBuilder builderAction;

        public MakeEfRandValElem(Data.EfActRandVal rv)
        {
            InitializeComponent();
            tbDataName.Text = dataNameHead;
            if (rv == null) rv = new Data.EfActRandVal();
            else tbDataName.Text = rv.dataName;
            // コントロール初期化
            defDataName = rv.dataName;
            tbUsage.Text = rv.usage;
            var tList = Singleton.EffectDataManagerSingleton.GetInstance().VarList;
            cbVarExport.Items.AddRange(tList.GetUserVariableNameList());
            cbVarExport.Text = rv.inputFor;
            numRandMax.Value = rv.randMax;
            builderAction = new DataBuilder.ActRandTableBuilder(btnAddAc, btnModAc, btnDelAc, btnSeekUpAc, btnSeekDnAc, dgvShowAc, rv.randData);
            CBChanged(null, null);
        }
        public bool SetData(Data.EfActRandVal rv)
        {
            rv.dataName = tbDataName.Text;
            rv.usage = tbUsage.Text;
            rv.inputFor = cbVarExport.Text;
            rv.randMax = decimal.ToInt32(numRandMax.Value);
            rv.randData = builderAction.GetData();
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
            string va = "代入先変数: " + baseData.VarList.GetData(cbVarExport.Text)?.usage;
            txtVarUsage.Text = va;
        }
    }
}
