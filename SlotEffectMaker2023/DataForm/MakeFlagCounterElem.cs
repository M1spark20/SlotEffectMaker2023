using System;
using System.Windows.Forms;

namespace SlotEffectMaker2023.DataForm
{
    public partial class MakeFlagCounterElem : SlotMaker2022.UserControl.FormElemDecide
    {
        public MakeFlagCounterElem(Data.FlagCounterCond fc)
        {
            InitializeComponent();
            if (fc == null) fc = new Data.FlagCounterCond();
           // コントロール初期化
            numFlag1.Minimum = byte.MinValue;
            numFlag1.Maximum = byte.MaxValue;
            numFlag1.Value = fc.FlagMin;
            numFlag2.Minimum = byte.MinValue;
            numFlag2.Maximum = byte.MaxValue;
            numFlag2.Value = fc.FlagMax;

            var itemList = Singleton.EffectDataManagerSingleton.GetInstance().VarList.GetVariableNameList();
            cbVarName.Items.AddRange(itemList);
            cbVarName.Text = fc.OutVar;
        }
        public bool SetData(Data.FlagCounterCond fc)
        {
            fc.OutVar = cbVarName.Text;
            fc.FlagMin = decimal.ToByte(numFlag1.Value <= numFlag2.Value ? numFlag1.Value : numFlag2.Value);
            fc.FlagMax = decimal.ToByte(numFlag1.Value <= numFlag2.Value ? numFlag2.Value : numFlag1.Value);
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (cbVarName.SelectedIndex < 0)
            {
                MessageBox.Show("出力先変数を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
