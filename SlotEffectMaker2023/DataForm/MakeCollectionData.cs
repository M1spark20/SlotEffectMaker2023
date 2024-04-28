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
    public partial class MakeCollectionData : SlotMaker2022.UserControl.FormElemDecide
    {
        private DataBuilder.CollectionBuilder builder;
        List<Data.CollectionDataElem> switcher;

        public MakeCollectionData(Data.CollectionData cd, Func<string[]> varList)
        {
            InitializeComponent();

            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            if (cd == null) cd = new Data.CollectionData();
            switcher = cd.Collections;

            // cb初期化
            cbJudge.Items.Add(string.Empty);
            cbJudge.Items.AddRange(varList());
            cbJudge.Text = cd.JudgeCondName;
            cbHazure.Items.Add(string.Empty);
            cbHazure.Items.AddRange(varList());
            cbHazure.Text = cd.JudgeHazure;
            cbAiming.Items.Add(string.Empty);
            cbAiming.Items.AddRange(varList());
            cbAiming.Text = cd.JudgeAiming;

            // dgv初期化
            builder = new DataBuilder.CollectionBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, switcher);
        }
        public bool SetData(Data.CollectionData cd)
        {
            cd.JudgeCondName = cbJudge.Text;
            cd.JudgeHazure = cbHazure.Text;
            cd.JudgeAiming = cbAiming.Text;
            cd.Collections = switcher;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            if (cbJudge.SelectedIndex < 0 || cbHazure.SelectedIndex < 0 || cbAiming.SelectedIndex < 0)
            {
                MessageBox.Show("変数を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
