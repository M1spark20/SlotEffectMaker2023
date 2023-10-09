using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlotMaker2022;
using System.Windows.Forms;
using System.Drawing;

namespace SlotEffectMaker2023.DataBuilder
{
    class SoundIDBuilder : ListBuilderBase<Data.SoundID, InfoSoundID>
    {   // サウンドID生成フォーム操作
        public SoundIDBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.SoundID> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "DataName";
            DGView.Columns[1].HeaderText = "ShotID";
            DGView.Columns[2].HeaderText = "LoopID";
            DGView.Columns[3].HeaderText = "LoopStart[ms]";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeSoundIDElem form = new DataForm.MakeSoundIDElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeSoundIDElem form = new DataForm.MakeSoundIDElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK) SetData(row.Index, form.SetData);
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoSoundID info = new InfoSoundID
                {
                    DataName = item.DataName,
                    Shot = item.ShotResName,
                    Loop = item.LoopResName,
                    LoopBegin = item.LoopBegin
                };
                Indicator.Add(info);
            }
            FinalizeIndicator(indexShift);
        }
    }
    class SoundPlayerBuilder : ListBuilderBase<Data.SoundPlayData, InfoSoundPlayData>
    {
        public SoundPlayerBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.SoundPlayData> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "PlayerName";
            DGView.Columns[1].HeaderText = "UseTimer";
            DGView.Columns[2].HeaderText = "Start[ms]";
            DGView.Columns[3].HeaderText = "Stop[ms]";
            DGView.Columns[4].HeaderText = "DefSoundID";
            DGView.CellFormatting += Format;
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeSoundPlayElem form = new DataForm.MakeSoundPlayElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeSoundPlayElem form = new DataForm.MakeSoundPlayElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK) SetData(row.Index, form.SetData);
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoSoundPlayData info = new InfoSoundPlayData
                {
                    playerName = item.PlayerName,
                    timerName = item.UseTimerName,
                    start = item.BeginTime,
                    stop = item.StopTime,
                    defSID = item.DefaultSoundID
                };
                Indicator.Add(info);
            }
            FinalizeIndicator(indexShift);
        }
        private void Format(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // データが存在しない場合赤背景にする
            DataGridView dgv = (DataGridView)sender;
            var ef = Singleton.EffectDataManagerSingleton.GetInstance();
            if (e.ColumnIndex == 1 && ef.TimerList.GetTimer(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
            if (e.ColumnIndex == 4 && ef.GetSoundID(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
    }
}
