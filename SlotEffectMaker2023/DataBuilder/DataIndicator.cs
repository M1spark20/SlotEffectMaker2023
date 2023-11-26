﻿using System;
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
    class InfoSoundPlayData 
    { 
        public string playerName { get; set; }
        public string timerName { get; set; }
        public int start { get; set; }
        public int stop { get; set; }
        public string defSID { get; set; }
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
    class InfoActChangeSound : InfoActBase
    {
        public string SoundPlayDataName { get; set; }
        public string VarRef { get; set; }
    }
}
