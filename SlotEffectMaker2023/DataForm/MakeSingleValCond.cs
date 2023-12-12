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
    public partial class MakeSingleValCond : SlotMaker2022.UserControl.FormElemDecide
    {
        string defDataName;
        public MakeSingleValCond(Data.EfValCond vc)
        {
            InitializeComponent();
            if (vc == null)
            {
                vc = new Data.EfValCond();
                numRange1.Value = 0;
                numRange2.Value = 0;
            }
            else
            {
                numRange1.Value = vc.min;
                numRange2.Value = vc.max;
            }
            defDataName = vc.valName;
            // コントロール初期化
            var vl = Singleton.EffectDataManagerSingleton.GetInstance().VarList;
            cbVar.Items.AddRange(vl.GetVariableNameList());
            cbVar.Text = vc.valName;
            numRange1.Maximum = int.MaxValue;
            numRange1.Minimum = int.MinValue;
            numRange2.Maximum = int.MaxValue;
            numRange2.Minimum = int.MinValue;
            chkInv.Checked = vc.invFlag;
        }
        public bool SetData(Data.EfValCond vc)
        {
            vc.valName = cbVar.Text;
            vc.min = decimal.ToInt32(Math.Min(numRange1.Value, numRange2.Value));
            vc.max = decimal.ToInt32(Math.Max(numRange1.Value, numRange2.Value));
            vc.invFlag = chkInv.Checked;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (cbVar.SelectedIndex < 0)
            {
                MessageBox.Show("ユーザ変数名を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
