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

                string srcVarName = Data[row.Index].name;
                DataForm.MakeVariableElem form = new DataForm.MakeVariableElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Var, srcVarName, Data[modIndex].name);
                }
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

                string srcVarName = Data[row.Index].UserTimerName;
                DataForm.MakeTimerElem form = new DataForm.MakeTimerElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Timer, srcVarName, Data[modIndex].UserTimerName);
                }
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
                string srcVarName = Data[row.Index].DataName;
                DataForm.MakeSoundIDElem form = new DataForm.MakeSoundIDElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.SoundID, srcVarName, Data[modIndex].DataName);
                }
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
    class SoundPlayerBuilder : ListBuilderBase<Data.SoundPlayData, InfoDataShifter>
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
            var sg = Singleton.EffectDataManagerSingleton.GetInstance();
            DataForm.MakeDataShifterElem form = new DataForm.MakeDataShifterElem(null, "プレイヤー名", "デフォルト音源", sg.GetSoundIDNameList());
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var sg = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                string srcVarName = Data[row.Index].ShifterName;
                string srcShotTimer = Data[row.Index].GetShotTimerName();
                string srcLoopTimer = Data[row.Index].GetLoopTimerName();

                DataForm.MakeDataShifterElem form = new DataForm.MakeDataShifterElem(Data[row.Index], "プレイヤー名", "デフォルト音源", sg.GetSoundIDNameList());
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    sg.Rename(SlotEffectMaker2023.Data.EChangeNameType.SoundPlayer, srcVarName, Data[modIndex].ShifterName);
                    // 自動生成タイマ名も更新する
                    sg.Rename(SlotEffectMaker2023.Data.EChangeNameType.Timer, srcShotTimer, Data[modIndex].GetShotTimerName());
                    sg.Rename(SlotEffectMaker2023.Data.EChangeNameType.Timer, srcLoopTimer, Data[modIndex].GetLoopTimerName());
                }
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoDataShifter info = new InfoDataShifter
                {
                    playerName = item.ShifterName,
                    timerName = item.UseTimerName,
                    start = item.BeginTime,
                    stop = item.StopTime,
                    defSID = item.DefaultElemID
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
        const string numName = "変数条件";
        const string actName = "鳴り分けデータ";
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
            DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(null, data.GetSoundIDNameList, SlotEffectMaker2023.Data.EChangeNameType.SoundID, numName, actName);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(Data[row.Index], data.GetSoundIDNameList, SlotEffectMaker2023.Data.EChangeNameType.SoundID, numName, actName);
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
    class ColorMapBuilder : ListBuilderBase<Data.ColorMap, InfoColorMap>
    {
        uint sizeW, sizeH;

        public ColorMapBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.ColorMap> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "Cards";
            DGView.Columns[1].HeaderText = "BeginTime";
            DGView.Columns[2].HeaderText = "LoopNum";
            DGView.Columns[3].HeaderText = "FadeFlag";
            DGView.Columns[4].HeaderText = "Speed";
            UpdateIndicator(0);
            sizeW = 0; sizeH = 0;
        }
        public void SetSize(uint w, uint h) { sizeW = w; sizeH = h; }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeColorMap form = new DataForm.MakeColorMap(null, sizeW, sizeH);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeColorMap form = new DataForm.MakeColorMap(Data[row.Index], sizeW, sizeH);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK) SetData(row.Index, form.SetData);
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();
            string[] speedName = new string[] { "Steady", "Acc", "Dec", "---" };

            foreach (var item in Data)
            {
                InfoColorMap info = new InfoColorMap
                {
                    CardNum = item.cardNum,
                    FadeFlag = item.fadeFlag ? "TRUE" : "FALSE",
                    BeginTime = item.beginTime,
                    LoopNum = item.loopCount,
                    Speed = speedName[(int)item.speed]
                };
                Indicator.Add(info);
            }
            FinalizeIndicator(indexShift);
        }
        public List<Data.ColorMap> GetData() { return Data; }
    }
    class ColorMapListElemBuilder : ListBuilderBase<Data.ColorMapList, InfoColorMapList>
    {
        public ColorMapListElemBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.ColorMapList> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "DataName";
            DGView.Columns[1].HeaderText = "Size(x,y)";
            DGView.Columns[2].HeaderText = "LoopTime";
            DGView.Columns[3].HeaderText = "Maps";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeColorMapListElem form = new DataForm.MakeColorMapListElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                string srcVarName = Data[row.Index].dataName;
                DataForm.MakeColorMapListElem form = new DataForm.MakeColorMapListElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.ColorMap, srcVarName, Data[modIndex].dataName);
                }
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();
            string[] speedName = new string[] { "Steady", "Acc", "Dec", "---" };

            foreach (var item in Data)
            {
                InfoColorMapList info = new InfoColorMapList
                {
                    DataName = item.dataName,
                    Size = "(" + item.sizeW.ToString() + ", " + item.sizeH.ToString() + ")",
                    LoopTime = item.loopTime,
                    ElemCount = item.elemData.Count
                };
                Indicator.Add(info);
            }
            FinalizeIndicator(indexShift);
        }
    }
    class ColorMapShifterBuilder : ListBuilderBase<Data.ColorMapShifter, InfoDataShifter>
    {
        public ColorMapShifterBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.ColorMapShifter> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "PlayerName";
            DGView.Columns[1].HeaderText = "UseTimer";
            DGView.Columns[2].HeaderText = "Start[ms]";
            DGView.Columns[3].HeaderText = "Stop[ms]";
            DGView.Columns[4].HeaderText = "DefMapID";
            DGView.CellFormatting += Format;
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            var sg = Singleton.EffectDataManagerSingleton.GetInstance();
            DataForm.MakeDataShifterElem form = new DataForm.MakeDataShifterElem(null, "プレイヤー名", "デフォルトMap", sg.ColorMap.GetMapListName());
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var sg = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                string srcVarName = Data[row.Index].ShifterName;

                DataForm.MakeDataShifterElem form = new DataForm.MakeDataShifterElem(Data[row.Index], "プレイヤー名", "デフォルトMap", sg.ColorMap.GetMapListName());
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    sg.Rename(SlotEffectMaker2023.Data.EChangeNameType.MapPlayer, srcVarName, Data[modIndex].ShifterName);
                }
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoDataShifter info = new InfoDataShifter
                {
                    playerName = item.ShifterName,
                    timerName = item.UseTimerName,
                    start = item.BeginTime,
                    stop = item.StopTime,
                    defSID = item.DefaultElemID
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
            if (e.ColumnIndex == 4 && ef.ColorMap.GetMapList(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
    }
    class MapSWBuilder : ListBuilderBase<Data.EfActionSwitch, InfoActionSwitch>
    {
        const string numName = "変数条件";
        const string actName = "適用MAPデータ";
        public MapSWBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActionSwitch> pData)
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
            DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(null, data.ColorMap.GetMapListName, SlotEffectMaker2023.Data.EChangeNameType.ColorMap, numName, actName);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(Data[row.Index], data.ColorMap.GetMapListName, SlotEffectMaker2023.Data.EChangeNameType.ColorMap, numName, actName);
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
            var ef = Singleton.EffectDataManagerSingleton.GetInstance().ColorMap;
            if (e.ColumnIndex == 1 && ef.GetMapList(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
    }
    class BonusConfigBuilder : ListBuilderBase<Data.BonusConfig, InfoBonusConfig>
    {
        public BonusConfigBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.BonusConfig> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "BonusID";
            DGView.Columns[1].HeaderText = "SymbolID";
            DGView.Columns[2].HeaderText = "TypeID";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            DataForm.MakeBonusConfigElem form = new DataForm.MakeBonusConfigElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeBonusConfigElem form = new DataForm.MakeBonusConfigElem(Data[row.Index]);
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
                InfoBonusConfig info = new InfoBonusConfig
                {
                    BonusID = item.BonusID,
                    SymbolID = item.ComaID,
                    TypeID = item.BonusType
                };
                Indicator.Add(info);
            }
            FinalizeIndicator(indexShift);
        }
    }
    class CollectionBuilder : ListBuilderBase<Data.CollectionDataElem, InfoCollection>
    {
        public CollectionBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.CollectionDataElem> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "No.";
            DGView.Columns[1].HeaderText = "Level";
            DGView.Columns[2].HeaderText = "ComaID-L";
            DGView.Columns[3].HeaderText = "SymbolID-L";
            DGView.Columns[4].HeaderText = "ComaID-C";
            DGView.Columns[5].HeaderText = "SymbolID-C";
            DGView.Columns[6].HeaderText = "ComaID-R";
            DGView.Columns[7].HeaderText = "SymbolID-R";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeCollectionDataElem form = new DataForm.MakeCollectionDataElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeCollectionDataElem form = new DataForm.MakeCollectionDataElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK) SetData(row.Index, form.SetData);
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            int count = 1;
            foreach (var item in Data)
            {
                string[] comaShow = { "---", "---", "ANY", "回転中", "はずれ", "?" };
                InfoCollection info = new InfoCollection
                {
                    No = count++,
                    Level = item.Level,
                    ComaID_L = item.CollectionElem[0].Pattern == SlotEffectMaker2023.Data.CollectionReelPattern.eReelPos ? item.CollectionElem[0].ReelPos.ToString() : comaShow[(int)item.CollectionElem[0].Pattern],
                    ComaID_C = item.CollectionElem[1].Pattern == SlotEffectMaker2023.Data.CollectionReelPattern.eReelPos ? item.CollectionElem[1].ReelPos.ToString() : comaShow[(int)item.CollectionElem[1].Pattern],
                    ComaID_R = item.CollectionElem[2].Pattern == SlotEffectMaker2023.Data.CollectionReelPattern.eReelPos ? item.CollectionElem[2].ReelPos.ToString() : comaShow[(int)item.CollectionElem[2].Pattern],
                    Symbol_L = item.CollectionElem[0].Pattern == SlotEffectMaker2023.Data.CollectionReelPattern.eComaItem ? 
                        item.CollectionElem[0].ComaItem[0].ToString() + " : " + item.CollectionElem[0].ComaItem[1].ToString() + " : " + item.CollectionElem[0].ComaItem[2].ToString() : "---",
                    Symbol_C = item.CollectionElem[1].Pattern == SlotEffectMaker2023.Data.CollectionReelPattern.eComaItem ? 
                        item.CollectionElem[1].ComaItem[0].ToString() + " : " + item.CollectionElem[1].ComaItem[1].ToString() + " : " + item.CollectionElem[1].ComaItem[2].ToString() : "---",
                    Symbol_R = item.CollectionElem[2].Pattern == SlotEffectMaker2023.Data.CollectionReelPattern.eComaItem ? 
                        item.CollectionElem[2].ComaItem[0].ToString() + " : " + item.CollectionElem[2].ComaItem[1].ToString() + " : " + item.CollectionElem[2].ComaItem[2].ToString() : "---",
                };
                Indicator.Add(info);
            }
            FinalizeIndicator(indexShift);
        }

    }

    class ActChangeSoundBuilder : ListBuilderBase<Data.EfActChangeSound, InfoActChangeElem>
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
                string srcVarName = Data[row.Index].dataName;
                DataForm.MakeActChangeSoundElem form = new DataForm.MakeActChangeSoundElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Timeline, srcVarName, Data[modIndex].dataName);
                }
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoActChangeElem info = new InfoActChangeElem
                {
                    DataName = item.dataName,
                    DataUsage = item.usage,
                    SoundPlayDataName = item.switcherName,
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
            if (e.ColumnIndex == 0 && ef.GetSoundPlayer(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
            if (e.ColumnIndex == 1 && ef.VarList.GetData(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
    }
    class ActChangeMapBuilder : ListBuilderBase<Data.EfActChangeMap, InfoActChangeElem>
    {
        public ActChangeMapBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActChangeMap> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "MapPlayID";
            DGView.Columns[1].HeaderText = "VariableRef";
            DGView.Columns[2].HeaderText = "EffectName";
            DGView.Columns[3].HeaderText = "Usage";
            DGView.CellFormatting += Format;
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeActChangeMapElem form = new DataForm.MakeActChangeMapElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                string srcVarName = Data[row.Index].dataName;
                DataForm.MakeActChangeMapElem form = new DataForm.MakeActChangeMapElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Timeline, srcVarName, Data[modIndex].dataName);
                }
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoActChangeElem info = new InfoActChangeElem
                {
                    DataName = item.dataName,
                    DataUsage = item.usage,
                    SoundPlayDataName = item.switcherName,
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
            if (e.ColumnIndex == 0 && ef.ColorMap.GetShifter(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
            if (e.ColumnIndex == 1 && ef.VarList.GetData(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
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
                string srcVarName = Data[row.Index].dataName;
                DataForm.MakeActValCondElem form = new DataForm.MakeActValCondElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Timeline, srcVarName, Data[modIndex].dataName);
                }
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
                string srcVarName = Data[row.Index].dataName;
                DataForm.MakeActTimerCondElem form = new DataForm.MakeActTimerCondElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Timeline, srcVarName, Data[modIndex].dataName);
                }
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
    class EfVarOPBuilder : ListBuilderBase<Data.EfActCtrlVal.OP, InfoEfVarOP>
    {
        public EfVarOPBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActCtrlVal.OP> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "Operand";
            DGView.Columns[1].HeaderText = "RightVal";
            UpdateIndicator(0);
            DGView.CellFormatting += Format;
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeEfVarOP form = new DataForm.MakeEfVarOP(null, Data.Count > 0);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeEfVarOP form = new DataForm.MakeEfVarOP(Data[row.Index], row.Index > 0);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK) SetData(row.Index, form.SetData);
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();
            string[] ops = { "+", "-", "*", "/", "%", "Err" };

            bool topData = true;
            foreach (var item in Data)
            {
                InfoEfVarOP info = new InfoEfVarOP
                {
                    OpRight = item.varName == string.Empty ? "Fix: " + item.fixVal.ToString() : item.varName,
                    Operand = topData ? string.Empty : ops[(int)item.op]
                };
                Indicator.Add(info);
                topData = false;
            }

            FinalizeIndicator(indexShift);
        }
        private void Format(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // データが存在しない場合赤背景にする
            DataGridView dgv = (DataGridView)sender;
            var ef = Singleton.EffectDataManagerSingleton.GetInstance();
            string cp = dgv[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (e.ColumnIndex == 1 && !cp.StartsWith("Fix: ") && ef.VarList.GetData(cp) == null)
                e.CellStyle.BackColor = Color.Red;
        }
        public List<Data.EfActCtrlVal.OP> GetData() { return Data; }
    }
    class ActCtrlValBuilder : ListBuilderBase<Data.EfActCtrlVal, InfoActCtrlVal>
    {
        public ActCtrlValBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActCtrlVal> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "TargetVar";
            DGView.Columns[1].HeaderText = "Operands";
            DGView.Columns[2].HeaderText = "EffectName";
            DGView.Columns[3].HeaderText = "Usage";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeEfVarCtrlElem form = new DataForm.MakeEfVarCtrlElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                string srcVarName = Data[row.Index].dataName;
                DataForm.MakeEfVarCtrlElem form = new DataForm.MakeEfVarCtrlElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Timeline, srcVarName, Data[modIndex].dataName);
                }
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoActCtrlVal info = new InfoActCtrlVal
                {
                    DataName = item.dataName,
                    DataUsage = item.usage,
                    OpCount = item.operands.Count,
                    TargetVar = item.valInputFor
                };
                Indicator.Add(info);
            }

            FinalizeIndicator(indexShift);
        }
    }
    class ActCtrlTimerBuilder : ListBuilderBase<Data.EfActCtrlTimer, InfoActCtrlTimer>
    {
        public ActCtrlTimerBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActCtrlTimer> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "TargetTimer";
            DGView.Columns[1].HeaderText = "Action";
            DGView.Columns[2].HeaderText = "ForceReset";
            DGView.Columns[3].HeaderText = "EffectName";
            DGView.Columns[4].HeaderText = "Usage";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeEfCtrlTimerElem form = new DataForm.MakeEfCtrlTimerElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                string srcVarName = Data[row.Index].dataName;
                DataForm.MakeEfCtrlTimerElem form = new DataForm.MakeEfCtrlTimerElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Timeline, srcVarName, Data[modIndex].dataName);
                }
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoActCtrlTimer info = new InfoActCtrlTimer
                {
                    DataName = item.dataName,
                    DataUsage = item.usage,
                    Action = item.setActivate ? "Start" : "Stop",
                    ForceReset = item.forceReset ? "TRUE" : "FALSE",
                    Timer = item.defName
                };
                Indicator.Add(info);
            }

            FinalizeIndicator(indexShift);
        }
    }
    class ActRandTableBuilder : ListBuilderBase<Data.EfActionSwitch, InfoRandTable>
    {
        public ActRandTableBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActionSwitch> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "DecVal";
            DGView.Columns[1].HeaderText = "Action";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(null, data.Timeline.GetAllActName, SlotEffectMaker2023.Data.EChangeNameType.Timeline, "減算値", "当選時Action");
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(Data[row.Index], data.Timeline.GetAllActName, SlotEffectMaker2023.Data.EChangeNameType.Timeline, "減算値", "当選時Action");
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
                InfoRandTable info = new InfoRandTable
                {
                    DecValue = item.condVal,
                    Action = item.actName
                };
                Indicator.Add(info);
            }

            FinalizeIndicator(indexShift);
        }
        public List<Data.EfActionSwitch> GetData() { return Data; }
    }
    class ActRandValBuilder : ListBuilderBase<Data.EfActRandVal, InfoActRandVal>
    {
        public ActRandValBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActRandVal> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "RandMax";
            DGView.Columns[1].HeaderText = "ElemSize";
            DGView.Columns[2].HeaderText = "EffectName";
            DGView.Columns[3].HeaderText = "Usage";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeEfRandValElem form = new DataForm.MakeEfRandValElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                string srcVarName = Data[row.Index].dataName;
                DataForm.MakeEfRandValElem form = new DataForm.MakeEfRandValElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Timeline, srcVarName, Data[modIndex].dataName);
                }
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoActRandVal info = new InfoActRandVal
                {
                    DataName = item.dataName,
                    DataUsage = item.usage,
                    RandMax = item.randMax,
                    ElemSize = item.randData.Count
                };
                Indicator.Add(info);
            }

            FinalizeIndicator(indexShift);
        }
    }
    class MultiVarSetBuilder : ListBuilderBase<Data.EfActionSwitch, InfoActionSwitch>
    {
        const string numName = "設定値";
        const string actName = "設定先変数";
        public MultiVarSetBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActionSwitch> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "Value";
            DGView.Columns[1].HeaderText = "InputFor";
            DGView.CellFormatting += Format;
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(null, data.VarList.GetUserVariableNameList, SlotEffectMaker2023.Data.EChangeNameType.Var, numName, actName);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DataForm.MakeActionSwitchElem form = new DataForm.MakeActionSwitchElem(Data[row.Index], data.VarList.GetUserVariableNameList, SlotEffectMaker2023.Data.EChangeNameType.Var, numName, actName);
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
            if (e.ColumnIndex == 1 && ef.VarList.GetData(dgv[e.ColumnIndex, e.RowIndex].Value.ToString()) == null)
                e.CellStyle.BackColor = Color.Red;
        }
    }
    class ActMultiVarBuilder : ListBuilderBase<Data.EfActMultiVarSet, InfoActMultiVar>
    {
        public ActMultiVarBuilder(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pIndicator, List<Data.EfActMultiVarSet> pData)
            : base(pAdd, pMod, pDel, pUp, pDown, pIndicator, pData)
        {
            DGView.Columns[0].HeaderText = "DataNum";
            DGView.Columns[1].HeaderText = "EffectName";
            DGView.Columns[2].HeaderText = "Usage";
            UpdateIndicator(0);
        }
        protected override void StartAdd(object sender, EventArgs e)
        {
            DataForm.MakeActMultiVarSetElem form = new DataForm.MakeActMultiVarSetElem(null);
            DialogResult res = form.ShowDialog();

            if (res == DialogResult.OK) SetData(-1, form.SetData);
            form.Dispose();
        }
        protected override void StartMod(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                string srcVarName = Data[row.Index].dataName;
                DataForm.MakeActMultiVarSetElem form = new DataForm.MakeActMultiVarSetElem(Data[row.Index]);
                DialogResult res = form.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int modIndex = row.Index;
                    SetData(row.Index, form.SetData);
                    Singleton.EffectDataManagerSingleton.GetInstance().Rename(SlotEffectMaker2023.Data.EChangeNameType.Timeline, srcVarName, Data[modIndex].dataName);
                }
                form.Dispose();
            }
        }
        protected override void UpdateIndicator(int indexShift)
        {
            InitIndicator();

            foreach (var item in Data)
            {
                InfoActMultiVar info = new InfoActMultiVar
                {
                    DataName = item.dataName,
                    DataUsage = item.usage,
                    ElemSize = item.setData.Count
                };
                Indicator.Add(info);
            }

            FinalizeIndicator(indexShift);
        }
    }
}
