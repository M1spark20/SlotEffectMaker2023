using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotEffectMaker2023.DataForm
{
    class MakeSoundPlay : DataBuilder.GeneralDataBuilder
    {
        DataBuilder.SoundPlayerBuilder builder;

        public MakeSoundPlay() : base("プレイヤー")
        {
            var sp = SlotEffectMaker2023.Singleton.EffectDataManagerSingleton.GetInstance().SoundPlayList;
            builder = new DataBuilder.SoundPlayerBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, sp);
        }
    }
}
