using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SlotMaker2022
{
    public class UserControl
    {
        public class NumericUpDown_AutoSelect : NumericUpDown
        {
            public NumericUpDown_AutoSelect()
            {
                this.GotFocus += OnSelected;
                this.Click += OnSelected;
            }
            private void OnSelected(object sender, EventArgs e)
            {
                this.Select(0, this.Text.Length);
            }
        }
        public class FormElemDecide : Form {
            protected virtual void BtnOK_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            protected virtual void BtnCancel_Click(object sender, EventArgs e)
            {
                DialogResult rst = MessageBox.Show("キャンセルしますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (rst == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }
    }
}
