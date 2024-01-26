using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataBuilder
{
    class InfoSlotVariable
    {
        public string DataName { get; set; }
        public int DefValue { get; set; }
        public string DataUsage { get; set; }
    }
    class InfoTimer
    {
        public string DataName { get; set; }
        public bool SaveFlag { get; set; }
        public string DataUsage { get; set; }
    }
    class InfoSoundID
    {
        public string DataName { get; set; }
        public string Shot { get; set; }
        public string Loop { get; set; }
        public int LoopBegin { get; set; }
    }
    class InfoDataShifter 
    { 
        public string playerName { get; set; }
        public string timerName { get; set; }
        public int start { get; set; }
        public int stop { get; set; }
        public string defSID { get; set; }
    }
    class InfoColorMap
    {
        public uint CardNum { get; set; }
        public int BeginTime { get; set; }
        public uint LoopNum { get; set; }
        public string FadeFlag { get; set; }
        public string Speed { get; set; }
    }
    class InfoColorMapList
    {
        public string DataName { get; set; }     // カラーマップの名前
        public string Size { get; set; }         // サイズ(x,y)
        public string UseTimerName { get; set; } // 制御に使用するタイマ名
        public int LoopTime { get; set; }        // ループ時間[ms]
        public int ElemCount { get; set; }       // 要素数
    }
    class InfoActBase
    {
        public string DataName { get; set; }
        public string DataUsage { get; set; }
    }
    class InfoActionSwitch
    {
        public int CondVal { get; set; }
        public string ActName { get; set; }
    }
    class InfoActChangeElem : InfoActBase
    {
        public string SoundPlayDataName { get; set; }
        public string VarRef { get; set; }
    }
    class InfoSingleValCond
    {
        public string CompValName { get; set; }
        public string Range { get; set; }
        public string InvFlag { get; set; }

    }
    class InfoValCondDS
    {
        public int No { get; set; }
        public int CondCount { get; set; }
    }
    class InfoActValCond : InfoActBase
    {
        public int CondCount { get; set; }
        public int ActCount { get; set; }
    }
    class InfoActCondTrig
    {
        public string Cond { get; set; }
        public string ActName { get; set; }
    }
    class InfoActTimerCond : InfoActBase
    {
        public string UseTimer { get; set; }
        public int Elapsed { get; set; }
        public string TrigHold { get; set; }
        public int ActCount { get; set; }
    }
    class InfoEfVarOP
    {
        public string Operand { get; set; }
        public string OpRight { get; set; }
    }
    class InfoActCtrlVal : InfoActBase
    {
        public string TargetVar { get; set; }
        public int OpCount { get; set; }
    }
    class InfoActCtrlTimer : InfoActBase
    {
        public string Timer { get; set; }
        public string Action { get; set; }
        public string ForceReset { get; set; }
    }
    class InfoRandTable
    {
        public int DecValue { get; set; }
        public string Action { get; set; }
    }
    class InfoActRandVal : InfoActBase
    {
        public int RandMax { get; set; }
        public int ElemSize { get; set; }
    }
    class InfoActMultiVar : InfoActBase
    {
        public int ElemSize { get; set; }
    }
}
