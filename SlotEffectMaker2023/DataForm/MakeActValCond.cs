using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeActValCond : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ActValCondBuilder builder;

        public MakeActValCond() : base("変数条件")
        {
            var ac = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().Timeline.condData;
            builder = new DataBuilder.ActValCondBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, ac);
        }
    }
}
