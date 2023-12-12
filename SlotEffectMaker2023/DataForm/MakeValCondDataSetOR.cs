using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeValCondDataSetOR : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ActValCondBuilderCondOR builder;

        public MakeValCondDataSetOR(List<Data.EfValCond> modData) : base("OR条件")
        {
            if (modData == null) return;
            builder = new DataBuilder.ActValCondBuilderCondOR(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, modData);
        }
    }
}
