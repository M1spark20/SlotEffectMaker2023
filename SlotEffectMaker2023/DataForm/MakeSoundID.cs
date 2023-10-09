using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeSoundID : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.SoundIDBuilder builder;

        public MakeSoundID() : base("音源データ")
        {
            var si = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().SoundIDList;
            builder = new DataBuilder.SoundIDBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, si);
        }
    }
}
