using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeVariable : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.SlotVariableBuilder builder;

        public MakeVariable() : base("ユーザ変数データ")
        {
            var sv = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().VarList;
            builder = new DataBuilder.SlotVariableBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, sv.VData);
        }
    }
}
