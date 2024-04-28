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
		public Action.DataShifterManager<Data.SoundPlayData>	soundData { get; set; }
		// カラーマップデータ
		public Action.DataShifterManager<Data.ColorMapShifter>	colorMapData { get; set; }
		// フリーズ関連データ
		public Action.FreezeManager			freezeManager { get; set; }
		// 履歴関連データ
		public Action.HistoryManager		historyManager { get; set; }
	
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
			soundData = new Action.DataShifterManager<Data.SoundPlayData>();
			colorMapData = new Action.DataShifterManager<Data.ColorMapShifter>();
			freezeManager = new Action.FreezeManager();
			historyManager = new Action.HistoryManager();
		}

		public void Init(List<Data.SoundPlayData> pSoundPlayData, Data.TimerList pTimer, Data.VarList pVar, List<Data.ColorMapShifter> pMapPlayData, Data.CollectionData pColle)
        {   // 各データへの初期値設定を行う
			timerData.Init(pTimer);
			valManager.Init(pVar);
			soundData.Init(pSoundPlayData);
			colorMapData.Init(pMapPlayData);
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
		
			return true;
		}
	
		/// <summary>
		/// システム変数を更新します。
		/// </summary>
		public void Process(){
			valManager.GetVariable("_slotSetting")		.val = basicData.slotSetting;
			valManager.GetVariable("_inCount")			.val = (int)basicData.inCount;
			valManager.GetVariable("_outCount")			.val = (int)basicData.outCount;
			valManager.GetVariable("_betCount")			.val = basicData.betCount;
			valManager.GetVariable("_creditCount")		.val = basicData.creditShow;
			valManager.GetVariable("_payoutCount")		.val = basicData.payoutShow;
			valManager.GetVariable("_isBetLatched")		.SetBool(basicData.isBetLatched);
			valManager.GetVariable("_isReplay")			.SetBool(basicData.isReplay);
			valManager.GetVariable("_gameMode")			.val = basicData.gameMode;
			valManager.GetVariable("_modeGameCount")	.val = basicData.modeGameCount;
			valManager.GetVariable("_modeJacCount")		.val = basicData.modeJacCount;
			valManager.GetVariable("_modeMedalCount")	.val = basicData.modeMedalCount;
			valManager.GetVariable("_RTMode")			.val = basicData.RTMode;
			valManager.GetVariable("_RTOverride")		.SetBool(basicData.RTOverride);
			valManager.GetVariable("_RTGameCount")		.val = basicData.RTGameCount;
			valManager.GetVariable("_flagID")			.val = basicData.castFlag;
			valManager.GetVariable("_bonusID")			.val = basicData.bonusFlag;
			valManager.GetVariable("_castBonusID")		.val = basicData.castBonusID;
			valManager.GetVariable("_payLine")			.val = decimal.ToInt32(basicData.castLines.Export());

			for (int i = 0; i < SlotMaker2022.LocalDataSet.REEL_MAX; ++i)
            {
				valManager.GetVariable("_reelPushPos[" + i + "]").val = reelData[i].pushPos;
				valManager.GetVariable("_reelStopPos[" + i + "]").val = reelData[i].stopPos;
				valManager.GetVariable("_reelStopOrder[" + i + "]").val = reelData[i].stopOrder;
            }

			// ボーナス回数を更新する
			historyManager.Process(valManager);

			// タイムラインを運用する
			var timeline = EffectDataManagerSingleton.GetInstance().Timeline.timerData;
			foreach (var item in timeline) item.Action();
		}
	}
}