using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotEffectMaker2023.DataBuilder
{
    public partial class GeneralDataBuilder : Form
    {
        public GeneralDataBuilder(string pBtnName)
        {
            InitializeComponent();
            btnAdd.Text = pBtnName + btnAdd.Text;
            btnMod.Text = pBtnName + btnMod.Text;
            btnDel.Text = pBtnName + btnDel.Text;
        }
    }
}
