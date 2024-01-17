using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeActMultiVarSet : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ActMultiVarBuilder builder;

        public MakeActMultiVarSet() : base("複数変数設定")
        {
            var tl = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            builder = new DataBuilder.ActMultiVarBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, tl.multiSetData);
        }
    }
}
