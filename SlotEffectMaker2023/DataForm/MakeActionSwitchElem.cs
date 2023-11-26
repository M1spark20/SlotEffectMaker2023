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
    public partial class MakeActionSwitchElem : SlotMaker2022.UserControl.FormElemDecide
    {
        public MakeActionSwitchElem(Data.EfActionSwitch sw, Func<string[]> txtFeeder)
        {
            InitializeComponent();
            if (sw == null) sw = new Data.EfActionSwitch();
            // コントロール初期化
            numCheckVal.Minimum = int.MinValue;
            numCheckVal.Maximum = int.MaxValue;
            numCheckVal.Value = sw.condVal;
            var itemList = txtFeeder();
            cbActName.Items.AddRange(itemList);
            cbActName.Text = sw.actName;
        }
        public bool SetData(Data.EfActionSwitch sw)
        {
            sw.condVal = decimal.ToInt32(numCheckVal.Value);
            sw.actName = cbActName.Text;
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
