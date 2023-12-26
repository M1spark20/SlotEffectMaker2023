using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeActTimerCond : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ActTimerCondBuilder builder;

        public MakeActTimerCond() : base("トリガ条件")
        {
            var tc = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().Timeline.timerData;
            builder = new DataBuilder.ActTimerCondBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, tc);
        }
    }
}
