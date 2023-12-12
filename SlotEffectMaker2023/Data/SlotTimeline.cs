﻿using System;
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
		public List<EfActValCond> condData;

        public SlotTimeline()
        {
            changeSound = new List<EfActChangeSound>();
			condData = new List<EfActValCond>();
        }
		public bool StoreData(ref BinaryWriter fs, int version)
		{
			fs.Write(changeSound.Count);
			foreach (var item in changeSound) 
				if (!item.StoreData(ref fs, version)) return false;
			fs.Write(condData.Count);
			foreach (var item in condData) 
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
			dataCount = fs.ReadInt32();
			for (int i = 0; i < dataCount; ++i)
			{
				EfActValCond vc = new EfActValCond();
				if (!vc.ReadData(ref fs, version)) return false;
				condData.Add(vc);
			}
			return true;
		}
		// 全Actの名前を得る
		public string[] GetAllActName()
        {
			List<string> vs = new List<string>();
			foreach (var item in changeSound) vs.Add(item.dataName);
			foreach (var item in condData) vs.Add(item.dataName);
			return vs.ToArray();
        }
		// Actのデータを得る
		public IEfAct GetActionFromName(string name)
        {
			foreach (var item in changeSound) if (item.dataName.Equals(name)) return item;
			foreach (var item in condData) if (item.dataName.Equals(name)) return item;
			return null;
        }
		// 指定した名前のActが存在するか確認する
		public bool IsActNameExist(string name)
        {
			return GetActionFromName(name) != null;
        }
	}
}
