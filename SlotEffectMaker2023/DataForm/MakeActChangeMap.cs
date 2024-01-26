using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeActChangeMap : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.ActChangeMapBuilder builder;

        public MakeActChangeMap() : base("カラーマップ変更")
        {
            var tl = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            builder = new DataBuilder.ActChangeMapBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, tl.changeMap);
        }
    }
}
