using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SlotEffectMaker2023.Data
{
    public enum CollectionReelPattern 
    {   // 各リールのデータがどのようなものか(リール位置, コマ情報, ANY, はずれ, 目押しはずれ)
        eReelPos, eComaItem, eAny, eRotating, eHazure, eAiming, eItemMax
    }

    public class CollectionReelElem : SlotMaker2022.ILocalDataInterface 
    {
        public CollectionReelPattern Pattern { get; set; }  // データ指定がリール位置か(true:リール位置/false:その他)
        public List<short> ComaItem { get; set; }           // 各コマのアイテム(index下段から)、マイナスで非停止時
        public byte ReelPos { get; set; }                   // リール位置

        public CollectionReelElem()
        {
            Pattern = CollectionReelPattern.eReelPos;
            ComaItem = new List<short>();
            for (int i = 0; i < SlotMaker2022.LocalDataSet.SHOW_MAX; ++i) ComaItem.Add(0);
            ReelPos = 0;
        }
		public bool StoreData(ref BinaryWriter fs, int version)
        {
            fs.Write((int)Pattern);
            fs.Write(ComaItem.Count);
            foreach (var item in ComaItem) fs.Write(item);
            fs.Write(ReelPos);
            return true;
        }
		public bool ReadData(ref BinaryReader fs, int version)
        {
            Pattern = (CollectionReelPattern)fs.ReadInt32();
            int dataSize = fs.ReadInt32();
            if (dataSize != SlotMaker2022.LocalDataSet.SHOW_MAX) return false;
            for (int i = 0; i < dataSize; ++i) ComaItem[i] = fs.ReadInt16();
            ReelPos = fs.ReadByte();
            return true;
        }
    }

    public class CollectionDataElem : SlotMaker2022.ILocalDataInterface
    {   // データをリール数分まとめたもの
        public List<CollectionReelElem> CollectionElem { get; set; }
        public byte Level { get; set; }

        public CollectionDataElem()
        {
            CollectionElem = new List<CollectionReelElem>();
            for (int i = 0; i < SlotMaker2022.LocalDataSet.REEL_MAX; ++i) CollectionElem.Add(new CollectionReelElem());
            Level = 1;
        }
		public bool StoreData(ref BinaryWriter fs, int version)
        {
            fs.Write(CollectionElem.Count);
            foreach (var item in CollectionElem)
                if (!item.StoreData(ref fs, version)) return false;
            fs.Write(Level);
            return true;
        }
		public bool ReadData(ref BinaryReader fs, int version)
        {
            int dataSize = fs.ReadInt32();
            if (dataSize != SlotMaker2022.LocalDataSet.REEL_MAX) return false;
            for (int i = 0; i < dataSize; ++i)
                if (!CollectionElem[i].ReadData(ref fs, version)) return false;
            Level = fs.ReadByte();
            return true;
        }
    }

    public class CollectionData : SlotMaker2022.ILocalDataInterface 
    {
        public List<CollectionDataElem> Collections { get; set; } // コレクションデータ(要素数、リール)

        public CollectionData()
        {
            Collections = new List<CollectionDataElem>();
        }
		public bool StoreData(ref BinaryWriter fs, int version)
        {
            fs.Write(Collections.Count);
            foreach (var item in Collections) 
                if (!item.StoreData(ref fs, version)) return false;
            return true;
        }
		public bool ReadData(ref BinaryReader fs, int version)
        {
            int dataSize = fs.ReadInt32();
            for (int i = 0; i < dataSize; ++i)
            {
                var data = new CollectionDataElem();
                if(!data.ReadData(ref fs, version)) return false;
                Collections.Add(data);
            }
            return true;
        }
    }
}
