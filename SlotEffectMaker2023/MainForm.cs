using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotEffectMaker2023
{
    public partial class MainForm : Form
    {
        // エフェクトデータインスタンス
        Singleton.EffectDataManagerSingleton effect;

        public MainForm()
        {
            InitializeComponent();

            // エフェクトデータデータ読み込み
            effect = Singleton.EffectDataManagerSingleton.GetInstance();
            effect.ReadData();

            // 終了時に保存処理を入れる
            this.FormClosing += new FormClosingEventHandler(SaveWorkingData);
        }

        // 終了時にデータを更新する
        private void SaveWorkingData(object sender, EventArgs e)
        {
            effect.SaveData();
        }

        private void StartModVariable(object sender, EventArgs e)
        {
            DataForm.MakeVariable form = new DataForm.MakeVariable();
            form.ShowDialog();
        }
        private void StartModTimer(object sender, EventArgs e)
        {
            DataForm.MakeTimer form = new DataForm.MakeTimer();
            form.ShowDialog();
        }
        private void StartModSoundID(object sender, EventArgs e)
        {
            DataForm.MakeSoundID form = new DataForm.MakeSoundID();
            form.ShowDialog();
        }
        private void StartModSoundPlay(object sender, EventArgs e)
        {
            DataForm.MakeSoundPlay form = new DataForm.MakeSoundPlay();
            form.ShowDialog();
        }
        private void StartModActChangeSound(object sender, EventArgs e)
        {
            DataForm.MakeActChangeSound form = new DataForm.MakeActChangeSound();
            form.ShowDialog();
        }
        private void StartModActValCond(object sender, EventArgs e)
        {
            DataForm.MakeActValCond form = new DataForm.MakeActValCond();
            form.ShowDialog();
        }
        private void StartModActTimerCond(object sender, EventArgs e)
        {
            DataForm.MakeActTimerCond form = new DataForm.MakeActTimerCond();
            form.ShowDialog();
        }
        private void StartModActValCtrl(object sender, EventArgs e)
        {
            DataForm.MakeActCtrlVal form = new DataForm.MakeActCtrlVal();
            form.ShowDialog();
        }
        private void StartModActCtrlTimer(object sender, EventArgs e)
        {
            DataForm.MakeEfCtrlTimer form = new DataForm.MakeEfCtrlTimer();
            form.ShowDialog();
        }
        private void StartModActRandData(object sender, EventArgs e)
        {
            DataForm.MakeActRandVal form = new DataForm.MakeActRandVal();
            form.ShowDialog();
        }
        private void StartModActMultiVarSet(object sender, EventArgs e)
        {
            DataForm.MakeActMultiVarSet form = new DataForm.MakeActMultiVarSet();
            form.ShowDialog();
        }
        private void StartModColorMapData(object sender, EventArgs e)
        {
            DataForm.MakeColorMapList cml = new DataForm.MakeColorMapList();
            cml.ShowDialog();
        }
        private void StartModColorMapShifter(object sender, EventArgs e)
        {
            DataForm.MakeMapPlay mp = new DataForm.MakeMapPlay();
            mp.ShowDialog();
        }
    }
}
