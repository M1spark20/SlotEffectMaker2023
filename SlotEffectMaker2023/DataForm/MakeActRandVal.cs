using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeActRandVal : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ActRandValBuilder builder;

        public MakeActRandVal() : base("乱数抽選")
        {
            var tl = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            builder = new DataBuilder.ActRandValBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, tl.randData);
        }
    }
}
