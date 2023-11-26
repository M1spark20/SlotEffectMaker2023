using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SlotEffectMaker2023.Data
{
    public class SlotTimeline : SlotMaker2022.ILocalDataInterface
    {
        public List<EfActChangeSound> changeSound;

        public SlotTimeline()
        {
            changeSound = new List<EfActChangeSound>();
        }
		public bool StoreData(ref BinaryWriter fs, int version)
		{
			fs.Write(changeSound.Count);
			foreach (var item in changeSound) 
				if (!item.StoreData(ref fs, version)) return false;
			return true;
		}
		public bool ReadData(ref BinaryReader fs, int version)
		{
			int dataCount = fs.ReadInt32();
			for (int i = 0; i < dataCount; ++i)
			{
				EfActChangeSound cs = new EfActChangeSound();
				if (!cs.ReadData(ref fs, version)) return false;
				changeSound.Add(cs);
			}
			return true;
		}
	}
}
