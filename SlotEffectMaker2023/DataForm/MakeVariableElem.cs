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
    public partial class MakeVariableElem : SlotMaker2022.UserControl.FormElemDecide
    {
        string defDataName;
        public MakeVariableElem(Data.SlotVariable sv)
        {
            InitializeComponent();
            if (sv == null) sv = new Data.SlotVariable();
            defDataName = sv.name;
            // コントロール初期化
            tbDataName.Text = sv.name;
            numLoopTime.Maximum = int.MaxValue;
            numLoopTime.Value = sv.val;
            tbUsage.Text = sv.usage;
        }
        public bool SetData(Data.SlotVariable sv)
        {
            sv.name = tbDataName.Text;
            sv.val = decimal.ToInt32(numLoopTime.Value);
            sv.usage = tbUsage.Text;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbDataName.Text.Equals(string.Empty))
            {
                MessageBox.Show("ユーザ変数名を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbDataName.Text.StartsWith("_"))
            {
                MessageBox.Show("アンダーバーから始まる変数はシステム用のため登録できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance().VarList;
            if (baseData.GetData(tbDataName.Text) != null && !defDataName.Equals(tbDataName.Text))
            {
                MessageBox.Show("ユーザ変数名が他のデータと重複しています。\n他の名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
