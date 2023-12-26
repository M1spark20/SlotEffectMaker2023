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
    class SlotVariableBuilder : ListBuilderBase<Data.SlotVariable, InfoSlotVariable>
    {
        public SlotVariableBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.SlotVariable> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "VarName";
            DGView.Columns[1].HeaderText = "DefaultVal";
            DGView.Columns[2].HeaderText = "Usage";
            UpdateIndicator(0);
            SwapLock(false);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeVariableElem form = new DataForm.MakeVariableElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                if (Data[row.Index].name.StartsWith("_")) { ModifyDeny(); return; }
                DataForm.MakeVariableElem form = new DataForm.MakeVariableElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK) SetData(row.Index, form.SetData);
                form.Dispose();
            }
        }
        protected override void StartDel(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                if (Data[row.Index].name.StartsWith("_")) { ModifyDeny(); return; }
            }
            base.StartDel(sender, e);
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoSlotVariable info = new InfoSlotVariable
                {
                    DataName = item.name,
                    DefValue = item.val,
                    DataUsage = item.usage
                };
                Indicator.Add(info);
            }
            FinalizeIndicator(indexShift);
        }
    }
    class SlotTimerBuilder : ListBuilderBase<Data.UserTimerData, InfoTimer>
    {
        public SlotTimerBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.UserTimerData> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "TimerName";
            DGView.Columns[1].HeaderText = "SaveFlag";
            DGView.Columns[2].HeaderText = "Usage";
            UpdateIndicator(0);
            SwapLock(false);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeTimerElem form = new DataForm.MakeTimerElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                if (!Data[row.Index].UserTimerName.StartsWith("$")) { ModifyDeny(); return; }
                DataForm.MakeTimerElem form = new DataForm.MakeTimerElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK) SetData(row.Index, form.SetData);
                form.Dispose();
            }
        }
        protected override void StartDel(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                if (!Data[row.Index].UserTimerName.StartsWith("$")) { ModifyDeny(); return; }
            }
            base.StartDel(sender, e);
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoTimer info = new InfoTimer
                {
                    DataName = item.UserTimerName,
                    SaveFlag = item.StoreActivation,
                    DataUsage = item.Usage
                };
                Indicator.Add(info);
            }
            FinalizeIndicator(indexShift);
        }
    }
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
            if (e.ColumnIndex == 1 && !ef.TimerList.CheckTimerExist(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()))
                e.CellStyle.BackColor = Color.Red;
            if (e.ColumnIndex == 4 && ef.GetSoundID(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
    }
    class SoundSWBuilder : ListBuilderBase<Data.EfActionSwitch, InfoActionSwitch>
    {
        public SoundSWBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActionSwitch> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "Value";
            DGView.Columns[1].HeaderText = "ActName";
            DGView.CellFormatting += Format;
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(null, data.GetSoundIDNameList);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(Data[row.Index], data.GetSoundIDNameList);
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
                InfoActionSwitch info = new InfoActionSwitch
                {
                    CondVal = item.condVal,
                    ActName = item.actName
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
            if (e.ColumnIndex == 1 && ef.GetSoundID(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
    }
    class ActChangeSoundBuilder : ListBuilderBase<Data.EfActChangeSound, InfoActChangeSound>
    {
        public ActChangeSoundBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActChangeSound> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "SoundPlayID";
            DGView.Columns[1].HeaderText = "VariableRef";
            DGView.Columns[2].HeaderText = "EffectName";
            DGView.Columns[3].HeaderText = "Usage";
            DGView.CellFormatting += Format;
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeActChangeSoundElem form = new DataForm.MakeActChangeSoundElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeActChangeSoundElem form = new DataForm.MakeActChangeSoundElem(Data[row.Index]);
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
                InfoActChangeSound info = new InfoActChangeSound
                {
                    DataName = item.dataName,
                    DataUsage = item.usage,
                    SoundPlayDataName = item.playDataName,
                    VarRef = item.variableRef
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
            if (e.ColumnIndex == 2 && ef.GetSoundID(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
            if (e.ColumnIndex == 3 && ef.VarList.GetData(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
    }
    class ActValCondBuilderCondOR : ListBuilderBase<Data.EfValCond, InfoSingleValCond>
    {
        public ActValCondBuilderCondOR(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfValCond> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "ValName";
            DGView.Columns[1].HeaderText = "Range";
            DGView.Columns[2].HeaderText = "Invert";
            DGView.CellFormatting += Format;
            UpdateIndicator(0);
        }
        private void Format(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // データが存在しない場合赤背景にする
            DataGridView dgv = (DataGridView)sender;
            var ef = Singleton.EffectDataManagerSingleton.GetInstance();
            if (e.ColumnIndex == 0 && ef.VarList.GetData(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeSingleValCond form = new DataForm.MakeSingleValCond(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeSingleValCond form = new DataForm.MakeSingleValCond(Data[row.Index]);
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
                InfoSingleValCond info = new InfoSingleValCond
                {
                    CompValName = item.valName,
                    Range = item.min.ToString() + " ～ " + item.max.ToString(),
                    InvFlag = item.invFlag ? "Invert" : ""
                };
                Indicator.Add(info);
            }

            FinalizeIndicator(indexShift);
        }
    }
    class ActValCondBuilderCondAND :  ListBuilderBase<List<Data.EfValCond>, InfoValCondDS>
    {
        public ActValCondBuilderCondAND(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<List<Data.EfValCond>> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "No";
            DGView.Columns[1].HeaderText = "ConditionNum";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            var tryData = new List<Data.EfValCond>();
            DataForm.MakeValCondDataSetOR form = new DataForm.MakeValCondDataSetOR(tryData);
            form.ShowDialog();
            if (tryData.Count > 0) Data.Add(tryData);
            UpdateIndicator(0);
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeValCondDataSetOR form = new DataForm.MakeValCondDataSetOR(Data[row.Index]);
                form.ShowDialog();
                UpdateIndicator(0);
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            int index = 1;
            foreach (var item in Data)
            {
                InfoValCondDS info = new InfoValCondDS
                {
                    No = index++,
                    CondCount = item.Count
                };
                Indicator.Add(info);
            }

            FinalizeIndicator(indexShift);
        }
        public List<List<Data.EfValCond>> GetData() { return Data; }
    }
    class ActValCondBuilder : ListBuilderBase<Data.EfActValCond, InfoActValCond>
    {
        public ActValCondBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActValCond> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "CondNum";
            DGView.Columns[1].HeaderText = "ActNum";
            DGView.Columns[2].HeaderText = "EffectName";
            DGView.Columns[3].HeaderText = "Usage";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeActValCondElem form = new DataForm.MakeActValCondElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeActValCondElem form = new DataForm.MakeActValCondElem(Data[row.Index]);
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
                InfoActValCond info = new InfoActValCond
                {
                    DataName = item.dataName,
                    DataUsage = item.usage,
                    CondCount = item.conds.Count,
                    ActCount = item.actionList.Count
                };
                Indicator.Add(info);
            }

            FinalizeIndicator(indexShift);
        }
    }
    class ActCondTrigBuilder : ListBuilderBase<Data.EfCondTrig, InfoActCondTrig>
    {
        bool m_condHold;

        public ActCondTrigBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfCondTrig> pData, bool condHold)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "Cond";
            DGView.Columns[1].HeaderText = "Action";
            UpdateIndicator(0);
            DGView.CellFormatting += Format;
            m_condHold = condHold;
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeEfCondTrig form = new DataForm.MakeEfCondTrig(null, m_condHold);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeEfCondTrig form = new DataForm.MakeEfCondTrig(Data[row.Index], m_condHold);
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
                InfoActCondTrig info = new InfoActCondTrig
                {
                    Cond = item.cdEnable ? "TRUE" : "FALSE",
                    ActName = item.actName
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
            if (e.ColumnIndex == 1 && ef.Timeline.GetActionFromName(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
        public List<Data.EfCondTrig> GetData() { return Data; }
    }
    class ActTimerCondBuilder : ListBuilderBase<Data.EfActTimerCond, InfoActTimerCond>
    {
        public ActTimerCondBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActTimerCond> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "TimerName";
            DGView.Columns[1].HeaderText = "Elapsed";
            DGView.Columns[2].HeaderText = "TrigHold";
            DGView.Columns[3].HeaderText = "ActNum";
            DGView.Columns[4].HeaderText = "EffectName";
            DGView.Columns[5].HeaderText = "Usage";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeActTimerCondElem form = new DataForm.MakeActTimerCondElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeActTimerCondElem form = new DataForm.MakeActTimerCondElem(Data[row.Index]);
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
                InfoActTimerCond info = new InfoActTimerCond
                {
                    DataName = item.dataName,
                    DataUsage = item.usage,
                    ActCount = item.action.Count,
                    UseTimer = item.cond.timerName,
                    Elapsed = item.cond.elapsed,
                    TrigHold = item.cond.trigHold ? "TRUE" : "FALSE"
                };
                Indicator.Add(info);
            }

            FinalizeIndicator(indexShift);
        }
    }
}
