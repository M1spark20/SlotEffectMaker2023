using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    public class MakeGameAchievement : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.GameAchievementBuilder builder;

        public MakeGameAchievement() : base("実績データ")
        {
            var ga = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().GameAchieve;
            builder = new DataBuilder.GameAchievementBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, ga.elemData);
        }
    }
}
