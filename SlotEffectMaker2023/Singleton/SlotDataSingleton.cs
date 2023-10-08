using System.Collections;
using System.Collections.Generic;

namespace SlotEffectMaker2023.Singleton {
	public sealed class SlotDataSingleton
	{
		public List<Data.ReelBasicData>	reelData  { get; set; }
		public Data.SlotBasicData		basicData { get; set; }
	
		// エフェクト用変数
		public Data.SlotValManager		valManager { get; set; }
	
		// 音源データ
		public Data.SoundDataList		soundData { get; set; }
	
		// Singletonインスタンス
		private static SlotDataSingleton ins = new SlotDataSingleton();
    
		/// <summary>
		/// インスタンスの初期化を行います。Singletonであるためprivateメンバです
		/// </summary>
		private SlotDataSingleton()
		{
			reelData = new List<Data.ReelBasicData>();
			basicData = new Data.SlotBasicData();
			valManager = new Data.SlotValManager();
			soundData = new Data.SoundDataList();
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
					reelData.Add(new Data.ReelBasicData(12));
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