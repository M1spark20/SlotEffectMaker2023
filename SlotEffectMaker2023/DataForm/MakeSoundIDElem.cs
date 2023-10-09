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
    public partial class MakeSoundIDElem : Form
    {
        public MakeSoundIDElem(Data.SoundID si)
        {
            InitializeComponent();
            if (si == null) si = new Data.SoundID();
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
    }
}
