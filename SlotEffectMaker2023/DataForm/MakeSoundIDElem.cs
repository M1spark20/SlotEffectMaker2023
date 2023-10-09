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
    public partial class MakeSoundIDElem : SlotMaker2022.UserControl.FormElemDecide
    {
        string defDataName;
        public MakeSoundIDElem(Data.SoundID si)
        {
            InitializeComponent();
            if (si == null) si = new Data.SoundID();
            defDataName = si.DataName;
            // コントロール初期化
            tbDataName.Text = si.DataName;
            tbShotRes.Text = si.ShotResName;
            tbLoopRes.Text = si.LoopResName;
            numLoopTime.Maximum = int.MaxValue;
            numLoopTime.Value = si.LoopBegin;
        }
        public bool SetData(Data.SoundID si)
        {
            si.DataName = tbDataName.Text;
            si.ShotResName = tbShotRes.Text;
            si.LoopResName = tbLoopRes.Text;
            si.LoopBegin = decimal.ToInt32(numLoopTime.Value);
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbDataName.Text.Equals(string.Empty))
            {
                MessageBox.Show("音源データ名を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance();
            if (baseData.GetSoundID(tbDataName.Text) != null && !defDataName.Equals(tbDataName.Text))
            {
                MessageBox.Show("音源データ名が他のデータと重複しています。\n他の名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.BtnOK_Click(sender, e);
        }

        private void Cancel(object sender, EventArgs e)
        {
            BtnCancel_Click(sender, e);
        }
        private void OK(object sender, EventArgs e)
        {
            BtnOK_Click(sender, e);
        }
    }
}
