using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeActCtrlVal : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ActCtrlValBuilder builder;

        public MakeActCtrlVal() : base("数値演算")
        {
            var tl = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            builder = new DataBuilder.ActCtrlValBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, tl.valOpData);
        }
    }
}
