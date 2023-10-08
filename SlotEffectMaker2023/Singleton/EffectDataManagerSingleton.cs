using System;
using System.Collections.Generic;
using System.Text;

namespace SlotEffectMaker2023.Singleton
{
    // メインROMデータ管理
    // データ上に1つだけ存在させたいためSingletonパターンを採用
    public sealed class EffectDataManagerSingleton
    {
        // ファイルバージョン
        const int FILE_VERSION = 0;

        // Singletonインスタンス
        private static EffectDataManagerSingleton ins = new EffectDataManagerSingleton();

        // データセット定義
        // public List<LocalDataSet.ILocalDataInterface> data { get; set }

        private EffectDataManagerSingleton()
        {
            // データセット初期化
        }
        public static EffectDataManagerSingleton GetInstance()
        {
            return ins;
        }
        public bool ReadData()
        {
           // ファイルから読み込み処理を行う(Unityでは処理内容を変更する)
            var rd = new SlotMaker2022.ProgressRead();
            if (rd.OpenFile("Effect.bytes"))
            {
                // if(!rd.ReadData(IF) return false;
                rd.Close();

                // バックアップ生成(Unity側では削除すること)
                BackupData();

                return true;
            }

            return false;
        }
        public bool SaveData()
        {
            var sw = new SlotMaker2022.ProgressWrite();
            if (sw.OpenFile("Effect.bytes", FILE_VERSION))
            {
                WriteOut(sw);
                sw.Flush();
                sw.Close();
            }
            return true;
        }

        // バックアップ生成
        public bool BackupData()
        {
            var sw = new SlotMaker2022.ProgressWrite();
            if (sw.OpenFile("backup.bak", FILE_VERSION))
            {
                WriteOut(sw);
                sw.Flush();
                sw.Close();
            }
            return true;
        }

        // データ書き出し
        private bool WriteOut(SlotMaker2022.ProgressWrite sw)
        {
            // 読み込み順はReadと揃えること
            // sw.WriteData(IF)
            return true;
        }

        /* プログラム内共通機能(全体での共有事項をここで定義) */
        // (None for now)
    }
}
