using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    class MakeMapPlay : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ColorMapShifterBuilder builder;

        public MakeMapPlay() : base("MAPプレイヤー")
        {
            var sf = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().ColorMap.shifter;
            builder = new DataBuilder.ColorMapShifterBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, sf);
        }
    }
}
