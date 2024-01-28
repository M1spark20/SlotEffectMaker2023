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
    public partial class MakeColorMapListElem : SlotMaker2022.UserControl.FormElemDecide
    {
        private DataBuilder.ColorMapBuilder builder;
        private List<Data.ColorMap> switcher;
        private string defName;

        public MakeColorMapListElem(Data.ColorMapList cm)
        {
            InitializeComponent();
            if (cm == null) cm = new Data.ColorMapList();
            defName = cm.dataName;

            // dgv初期化
            switcher = new List<Data.ColorMap>();
            switcher.AddRange(cm.elemData);
            builder = new DataBuilder.ColorMapBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, switcher);
            dgvShow.DataBindingComplete += LockMapSize;

            tbDataName.Text = cm.dataName;
            numX.Maximum = int.MaxValue;
            numY.Maximum = int.MaxValue;
            numX.Value = cm.sizeW;
            numY.Value = cm.sizeH;
            numLoopTime.Maximum = int.MaxValue;
            numLoopTime.Value = cm.loopTime;
        }
        public bool SetData(Data.ColorMapList cm)
        {
            cm.dataName = tbDataName.Text;
            cm.sizeW = decimal.ToUInt32(numX.Value);
            cm.sizeH = decimal.ToUInt32(numY.Value);
            cm.loopTime = decimal.ToInt32(numLoopTime.Value);
            cm.elemData = builder.GetData();
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance().ColorMap;
            if (tbDataName.Text.Equals(string.Empty))
            {
                MessageBox.Show("データ名を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (baseData.GetMapList(tbDataName.Text) != null && !defName.Equals(tbDataName.Text))
            {
                MessageBox.Show("データ名が他のデータと重複しています。\n他の名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.BtnOK_Click(sender, e);
        }
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }

        private void SetMapSize(object sender, EventArgs e)
        {
            builder.SetSize(decimal.ToUInt32(numX.Value), decimal.ToUInt32(numY.Value));
        }
        private void LockMapSize(object sender, EventArgs e)
        {
            numX.Enabled = switcher.Count == 0;
            numY.Enabled = switcher.Count == 0;
        }
    }
}
