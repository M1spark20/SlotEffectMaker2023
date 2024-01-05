using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeEfCtrlTimer : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ActCtrlTimerBuilder builder;

        public MakeEfCtrlTimer() : base("タイマ制御")
        {
            var ct = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().Timeline.ctrlTimer;
            builder = new DataBuilder.ActCtrlTimerBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, ct);
        }
    }
}
