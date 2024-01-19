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
        Data.EChangeNameType type;
        public MakeActionSwitchElem(Data.EfActionSwitch sw, Func<string[]> txtFeeder, Data.EChangeNameType nameType, string numName, string actName)
        {
            InitializeComponent();
            if (sw == null) sw = new Data.EfActionSwitch();
            type = nameType;
            // コントロール初期化
            labelNum.Text = numName;
            labelAct.Text = actName;
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
            sw.SetRenameType(type);
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
