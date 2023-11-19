using System.Collections.Generic;
using System.IO;
using SlotEffectMaker2023.Data;

namespace SlotEffectMaker2023.Action
{
    // サウンドデータ管理クラス(Sav)
    public class SoundDataManager : SlotMaker2022.ILocalDataInterface
	{
		// 変数
		List<(string playName, string soundName)> SoundID { get; set; }	// 鳴り分けデータ(PlayList, IDList)

		public SoundDataManager()
		{
			SoundID = new List<(string, string)>();
		}
		// 最初に鳴り分け要素を作成しておく
		public void Init(List<Data.SoundPlayData> pPlayData)
        {
			foreach (var item in pPlayData)
				SoundID.Add( (item.PlayerName, item.DefaultSoundID) );
		}
		// 現在の鳴り分け状況を保存する
		public bool StoreData(ref BinaryWriter fs, int version)
		{
			fs.Write(SoundID.Count);
			for (int i = 0; i < SoundID.Count; ++i)
            {
				fs.Write(SoundID[i].playName);
				fs.Write(SoundID[i].soundName);
            }
			return true;
		}
		public bool ReadData(ref BinaryReader fs, int version)
		{
			int dataSize = fs.ReadInt32();
			for (int i = 0; i < dataSize; ++i)
			{
				(string playName, string soundName) newData;
				newData.playName = fs.ReadString();
				newData.soundName = fs.ReadString();
				SoundID.Add(newData);
			}
			return true;
		}

		// データ編集用関数
		public void ChangeSoundID(string pPlayerID, string pSoundID)
		{
			for (int i = 0; i < SoundID.Count; ++i)
			{
                if (SoundID[i].playName == pPlayerID) { SoundID[i] = (pPlayerID, pSoundID); return; }
			}
			// データがない場合の追加
			SoundID.Add( (pPlayerID, pSoundID) );
		}
	}
}