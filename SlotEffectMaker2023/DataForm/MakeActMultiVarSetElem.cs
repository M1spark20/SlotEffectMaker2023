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
    public partial class MakeActMultiVarSetElem : SlotMaker2022.UserControl.FormElemDecide
    {
        private static string dataNameHead = "ActMV";
        private DataBuilder.MultiVarSetBuilder builder;
        private List<Data.EfActionSwitch> switcher;
        string defDataName;

        public MakeActMultiVarSetElem(Data.EfActMultiVarSet mv)
        {
            InitializeComponent();

            var data = Singleton.EffectDataManagerSingleton.GetInstance();

            tbDataName.Text = dataNameHead;
            if (mv == null) mv = new Data.EfActMultiVarSet();
            else tbDataName.Text = mv.dataName;
            tbUsage.Text = mv.usage;
            defDataName = mv.dataName;

            // cb初期化
            switcher = mv.setData;

            // dgv初期化
            builder = new DataBuilder.MultiVarSetBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, switcher);
        }
        public bool SetData(Data.EfActMultiVarSet mv)
        {
            mv.dataName = tbDataName.Text;
            mv.usage = tbUsage.Text;
            mv.setData = switcher;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            if (!tbDataName.Text.StartsWith(dataNameHead))
            {
                MessageBox.Show("データ名は"+dataNameHead+"から始めてください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
