using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeColorMapList : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ColorMapListElemBuilder builder;

        public MakeColorMapList() : base("カラーマップ")
        {
            var cm = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().ColorMap;
            builder = new DataBuilder.ColorMapListElemBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, cm.mapList);
        }
    }
}
