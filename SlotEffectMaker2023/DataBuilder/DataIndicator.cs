using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataBuilder
{
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
}
