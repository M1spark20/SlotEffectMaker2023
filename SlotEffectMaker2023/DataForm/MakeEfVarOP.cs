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
    public partial class MakeEfVarOP : SlotMaker2022.UserControl.FormElemDecide
    {
        public MakeEfVarOP(Data.EfActCtrlVal.OP op, bool ctrlOperand)
        {
            InitializeComponent();
            if (op == null) op = new Data.EfActCtrlVal.OP();
            // コントロール初期化
            var acts = Singleton.EffectDataManagerSingleton.GetInstance().VarList;
            var itemList = acts.GetVariableNameList();
            cbVarName.Items.AddRange(itemList);
            cbVarName.Text = op.varName;
            rbVar.Checked = op.varName != string.Empty;
            rbFix.Checked = !rbVar.Checked;
            numFixVal.Value = op.fixVal;
            CheckedChanged(null, null);
            CBChanged(null, null);

            string[] opName = { "ADD(+)", "SUB(-)", "MUL(*)", "DIV(/)", "MOD(%)" };
            cbOperand.Items.AddRange(opName);
            cbOperand.SelectedIndex = (int)op.op;
            cbOperand.Enabled = ctrlOperand;
        }
        public bool SetData(Data.EfActCtrlVal.OP op)
        {
            op.varName = string.Empty;
            op.fixVal = 0;
            if (rbVar.Checked) op.varName = cbVarName.Text;
            if (rbFix.Checked) op.fixVal = decimal.ToInt32(numFixVal.Value);
            op.op = (Data.ECalcOperand)cbOperand.SelectedIndex;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (rbVar.Checked && cbVarName.SelectedIndex < 0)
            {
                MessageBox.Show("右辺データ(変数)を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbOperand.SelectedIndex < 0)
            {
                MessageBox.Show("オペランドを設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.BtnOK_Click(sender, e);
        }
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            cbVarName.Enabled = rbVar.Checked;
            numFixVal.Enabled = rbFix.Checked;
        }
        private void CBChanged(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance();
            string va = "右辺データ: : " + baseData.VarList.GetData(cbVarName.Text)?.usage;
            txtVarUsage.Text = va;
        }
    }
}
