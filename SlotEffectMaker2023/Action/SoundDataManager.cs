using System.Collections.Generic;
using System.IO;
using SlotEffectMaker2023.Data;

namespace SlotEffectMaker2023.Action
{
    // サウンドデータ管理クラス(Sav)
    public class SoundDataManager : SlotMaker2022.ILocalDataInterface
	{
		// 変数
		List<SoundID> IDList;
		List<SoundPlayData> PlayList;
		public List<int> SoundID { get; set; }

		public SoundDataManager()
		{
			IDList = new List<SoundID>();
			PlayList = new List<SoundPlayData>();
			SoundID = new List<int>();
		}
		// Sysからデータを作成する
		public void Init(List<SoundID> pIDs, List<SoundPlayData> pPlayData, TimerList pTimer)
        {   // 引数はデータ入力済みであること
			foreach (var item in pIDs) AddID(item);
			foreach (var item in pPlayData) AddPlayData(item, pTimer);
        }

		public bool StoreData(ref BinaryWriter fs, int version)
		{
			fs.Write(IDList.Count);
			for (int i = 0; i < IDList.Count; ++i)
				if (!IDList[i].StoreData(ref fs, version)) return false;

			fs.Write(PlayList.Count);
			for (int i = 0; i < PlayList.Count; ++i)
				if (!PlayList[i].StoreData(ref fs, version)) return false;

			return true;
		}
		public bool ReadData(ref BinaryReader fs, int version)
		{
			int dataSize = fs.ReadInt32();
			for (int i = 0; i < dataSize; ++i)
			{
				var newData = new SoundID();
				if (!newData.ReadData(ref fs, version)) return false;
				IDList.Add(newData);
			}

			dataSize = fs.ReadInt32();
			for (int i = 0; i < dataSize; ++i)
			{
				var newData = new SoundPlayData();
				if (!newData.ReadData(ref fs, version)) return false;
				PlayList.Add(newData);
			}

			return true;
		}

		// データ編集用関数
		public void AddID(SoundID data) { IDList.Add(data); }
		public void AddPlayData(SoundPlayData data, TimerList timerList)
		{
			data.MakeTimer(timerList);
			PlayList.Add(data);
			SoundID.Add(data.DefaultSoundID);
		}
		public void ChangeSoundID(int pPlayID, int pSoundID)
		{
			if (pPlayID < 0 || pPlayID >= SoundID.Count) return;
			if (pSoundID < 0 || pSoundID >= IDList.Count) return;
			SoundID[pPlayID] = pSoundID;
		}

		// 音源データを仮生成する
		public void DataStab(ref TimerList timerList)
		{
			// 音のデータ
			SoundID sid = new SoundID();
			sid.DataName = "None";
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "Bet";
			sid.ShotResName = "SE_Bet";
			sid.LoopBegin = 0;
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "Start";
			sid.ShotResName = "SE_Start";
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "StopDef";
			sid.ShotResName = "SE_Stop";
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "ReplayIn";
			sid.ShotResName = "SE_ReplayIn";
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "PayoutCherry";
			sid.ShotResName = "SE_Payout";
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "Wait";
			sid.LoopResName = "SE_Wait";
			sid.LoopBegin = 0;
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "PayoutBell";
			sid.LoopResName = "SE_Payout";
			sid.LoopBegin = 0;
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "PayoutGrape";
			sid.LoopResName = "SE_PayoutGrape";
			sid.LoopBegin = 0;
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "PayoutJac";
			sid.LoopResName = "SE_PayoutJac";
			sid.LoopBegin = 0;
			AddID(sid);

			sid = new SoundID();
			sid.DataName = "PayoutTech";
			sid.ShotResName = "SE_PayoutTech";
			AddID(sid);

			// 再生側のデータ
			SoundPlayData pid = new SoundPlayData();
			pid.PlayerName = "Bet";
			pid.UseTimerName = "betShot";
			pid.DefaultSoundID = 1;
			AddPlayData(pid, timerList);

			pid = new SoundPlayData();
			pid.PlayerName = "Wait";
			pid.UseTimerName = "waitStart";
			pid.DefaultSoundID = 6;
			AddPlayData(pid, timerList);

			pid = new SoundPlayData();
			pid.PlayerName = "Start";
			pid.UseTimerName = "reelStart";
			pid.DefaultSoundID = 2;
			AddPlayData(pid, timerList);

			pid = new SoundPlayData();
			pid.PlayerName = "Stop";
			pid.UseTimerName = "anyReelPush";
			pid.DefaultSoundID = 3;
			AddPlayData(pid, timerList);

			pid = new SoundPlayData();
			pid.PlayerName = "Payout";
			pid.UseTimerName = "payoutTime";
			pid.DefaultSoundID = 4;
			AddPlayData(pid, timerList);
		}
	}
}