using System.Collections;
using System.Collections.Generic;

namespace SlotEffectMaker2023.Singleton {
	public sealed class SlotDataSingleton
	{	// スロット上で動くデータを定義する
		public List<Action.ReelBasicData>	reelData  { get; set; }
		public Action.SlotBasicData			basicData { get; set; }
		public Action.SlotTimerManager		timerData { get; set; }
		// エフェクト用変数
		public Action.SlotValManager		valManager { get; set; }
		// 音源データ
		public Action.SoundDataList			soundData { get; set; }
	
		// Singletonインスタンス
		private static SlotDataSingleton ins = new SlotDataSingleton();
    
		/// <summary>
		/// インスタンスの初期化を行います。Singletonであるためprivateメンバです
		/// </summary>
		private SlotDataSingleton()
		{
			timerData = new Action.SlotTimerManager();
			reelData = new List<Action.ReelBasicData>();
			basicData = new Action.SlotBasicData();
			valManager = new Action.SlotValManager();
			soundData = new Action.SoundDataList();
		}

		public void Init(List<Data.SoundID> pSound, List<Data.SoundPlayData> pPlayData, Data.TimerList pTimer)
        {   // 各データへの初期値設定を行う
			timerData.Init(pTimer);
			soundData.Init(pSound, pPlayData, pTimer);
        }
	
		/// <summary>
		/// インスタンスの取得を行います。
		/// </summary>
		public static SlotDataSingleton GetInstance() { return ins; }
	
		public bool ReadData(ref Data.TimerList timerList){
			// 読み込み処理
			// reelData
			// basicData
			valManager.ReadData();
		
			// データが読み込めなかった場合にリール情報を新規生成する
			if (reelData.Count == 0){
				for (int i=0; i<SlotMaker2022.LocalDataSet.REEL_MAX; ++i){
					reelData.Add(new Action.ReelBasicData(12));
				}
			}
		
			// soundData
			soundData.DataStab(ref timerList);
		
			return true;
		}
	
		/// <summary>
		/// システム変数を更新します。
		/// </summary>
		public void Process(){
			valManager.GetVariable("_betCount")		.val = basicData.betCount;
			valManager.GetVariable("_creditCount")	.val = basicData.creditShow;
			valManager.GetVariable("_payoutCount")	.val = basicData.payoutShow;
			valManager.GetVariable("_isReplay")		.SetBool(basicData.isReplay);
		}
	}
}