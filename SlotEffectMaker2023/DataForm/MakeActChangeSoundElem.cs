using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotEffectMaker2023.DataForm
{
    public partial class MakeActChangeSoundElem : SlotMaker2022.UserControl.FormElemDecide
    {
        private static string dataNameHead = "ActCS";
        private DataBuilder.SoundSWBuilder builder;
        private List<Data.EfActionSwitch> switcher;
        string defDataName;

        public MakeActChangeSoundElem(Data.EfActChangeSound si)
        {
            InitializeComponent();

            var data = Singleton.EffectDataManagerSingleton.GetInstance();

            tbDataName.Text = dataNameHead;
            if (si == null) si = new Data.EfActChangeSound();
            else tbDataName.Text = si.dataName;
            tbUsage.Text = si.usage;
            defDataName = si.dataName;

            // cb初期化
            cbPlay.Items.AddRange(data.GetSoundPlayerNameList());
            cbPlay.Text = si.playDataName;
            cbVar.Items.AddRange(data.VarList.GetVariableNameList());
            cbVar.Text = si.variableRef;
            switcher = si.switcher;
            CBChanged(null, null);

            // dgv初期化
            builder = new DataBuilder.SoundSWBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, switcher);
        }
        public bool SetData(Data.EfActChangeSound si)
        {
            si.dataName = tbDataName.Text;
            si.usage = tbUsage.Text;
            si.playDataName = cbPlay.SelectedItem.ToString();
            if (cbVar.SelectedIndex < 0) si.variableRef = string.Empty;
            else si.variableRef = cbVar.SelectedItem.ToString();
            si.switcher = switcher;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance().Timeline;
            if (!tbDataName.Text.StartsWith(dataNameHead))
            {
                MessageBox.Show("データ名は"+dataNameHead+"から始めてください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (baseData.IsActNameExist(tbDataName.Text) && !defDataName.Equals(tbDataName.Text))
            {
                MessageBox.Show("データ名が他のデータと重複しています。\n他の名前を指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbPlay.SelectedIndex < 0)
            {
                MessageBox.Show("制御プレイヤーを選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbVar.SelectedIndex < 0)
            {
                var ans = MessageBox.Show("制御変数が空です。常にデフォルト音源を指定しますがよろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ans == DialogResult.No) return;
            }
            base.BtnOK_Click(sender, e);
        }

        private void Cancel(object sender, EventArgs e)
        {
            BtnCancel_Click(sender, e);
        }
        private void OK(object sender, EventArgs e)
        {
            BtnOK_Click(sender, e);
        }
        private void CBChanged(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance();
            string va = "制御変数: " + baseData.VarList.GetData(cbVar.Text)?.usage;
            txtVarUsage.Text = va;
        }
    }
}
