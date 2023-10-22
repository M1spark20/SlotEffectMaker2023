using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeTimer : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.SlotTimerBuilder builder;

        public MakeTimer() : base("ユーザタイマデータ")
        {
            var tl = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().TimerList;
            builder = new DataBuilder.SlotTimerBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, tl.TData);
        }
    }
}
