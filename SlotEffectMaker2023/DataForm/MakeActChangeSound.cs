using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeActChangeSound : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ActChangeSoundBuilder builder;

        public MakeActChangeSound() : base("音源変更")
        {
            var tl = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            builder = new DataBuilder.ActChangeSoundBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, tl.changeSound);
        }
    }
}
