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
    public partial class MakeEfRandTable : SlotMaker2022.UserControl.FormElemDecide
    {
        public MakeEfRandTable(Data.EfRandTable rt)
        {
            InitializeComponent();
            if (rt == null) rt = new Data.EfRandTable();
            // 要素数調整
            // コントロール初期化
            numDecVal.Minimum = int.MinValue;
            numDecVal.Maximum = int.MaxValue;
            numApplyBase.Minimum = int.MinValue;
            numApplyBase.Maximum = int.MaxValue;
            numDecVal.Value = rt.decValue;
            numApplyBase.Value = rt.applyValue;
        }
        public bool SetData(Data.EfRandTable rt)
        {
            rt.decValue = decimal.ToInt32(numDecVal.Value);
            rt.applyValue = decimal.ToInt32(numApplyBase.Value);
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            base.BtnOK_Click(sender, e);
        }
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }
    }
}
