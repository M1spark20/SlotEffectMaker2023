using System;
using System.Windows.Forms;

namespace SlotEffectMaker2023.DataForm
{
    public partial class MakeGameAchievementElem : SlotMaker2022.UserControl.FormElemDecide
    {
        private static string dataNameHead = "AC_";
        string defDataName;

        public MakeGameAchievementElem(Data.GameAchievement ga)
        {
            InitializeComponent();
            tbDataName.Text = dataNameHead;
            if (ga == null) ga = new Data.GameAchievement();
            else tbDataName.Text = ga.DataID;

            // コントロール初期化
            defDataName = ga.DataID;
            rbData.Checked = ga.Type == Data.AchieveDataType.Num;
            rbFlag.Checked = ga.Type == Data.AchieveDataType.Flag;
            chkOnlyBonus.Checked = ga.UpdateOnlyBonusIn;

            var variables = Singleton.EffectDataManagerSingleton.GetInstance().VarList.GetVariableNameList();
            var conditions = Singleton.EffectDataManagerSingleton.GetInstance().Timeline.GetAllCondName();
            cbVarName.Items.AddRange(variables);
            cbVarName.Text = rbData.Checked ? ga.RefData : string.Empty;
            cbCondName.Items.AddRange(conditions);
            cbCondName.Text = rbFlag.Checked ? ga.RefData : string.Empty;
            CheckedChanged(null, null);
        }
        public bool SetData(Data.GameAchievement ga)
        {
            ga.DataID = tbDataName.Text;
            if (rbData.Checked)
            {
                ga.Type = Data.AchieveDataType.Num;
                ga.RefData = cbVarName.Text;
            }
            if (rbFlag.Checked)
            {
                ga.Type = Data.AchieveDataType.Flag;
                ga.RefData = cbCondName.Text;
            }
            ga.UpdateOnlyBonusIn = chkOnlyBonus.Checked;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (cbVarName.SelectedIndex < 0 && rbData.Checked)
            {
                MessageBox.Show("データ保存変数を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbCondName.SelectedIndex < 0 && rbFlag.Checked)
            {
                MessageBox.Show("実績達成条件を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!tbDataName.Text.StartsWith(dataNameHead))
            {
                MessageBox.Show("データ名は" + dataNameHead + "から始めてください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*if (baseData.IsActNameExist(tbDataName.Text) && !defDataName.Equals(tbDataName.Text))
            {
                MessageBox.Show("データ名が他のデータと重複しています。\n他の名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            base.BtnOK_Click(sender, e);
        }
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            cbVarName.Enabled = rbData.Checked;
            cbCondName.Enabled = rbFlag.Checked;
        }
    }
}
