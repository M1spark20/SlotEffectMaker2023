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
    public partial class MakeHistoryConfig : SlotMaker2022.UserControl.FormElemDecide
    {
        private DataBuilder.BonusConfigBuilder builder;
        private List<Data.BonusConfig> bConf;

        private Label[] txtBCount;
        private ComboBox[] cbBCount;
        private Label[] expBCount;

        public MakeHistoryConfig(Data.HistoryConfig hc, Func<string[]> varList)
        {
            InitializeComponent();

            var data = Singleton.EffectDataManagerSingleton.GetInstance();
            const int typeMax = Data.HistoryConfig.BONUS_TYPE_MAX;
            txtBCount = new Label[typeMax];
            cbBCount = new ComboBox[typeMax];
            expBCount = new Label[typeMax];

            if (hc == null) hc = new Data.HistoryConfig();

            // cb動的生成
            const int cbDiffY = 45;
            const int expDiffY = 15;
            for (int i = 0; i < typeMax; ++i)
            {
                txtBCount[i] = new Label
                {
                    Text = "ボナ回数格納先(Type" + (i + 1).ToString() + ")",
                    Location = new Point(txtBCountTotal.Location.X, txtBCountTotal.Location.Y + cbDiffY * (i + 1)),
                    AutoSize = txtBCountTotal.AutoSize
                };
                expBCount[i] = new Label
                {
                    Location = new Point(expBCountTotal.Location.X, expBCountTotal.Location.Y + expDiffY * (i + 1)),
                    AutoSize = expBCountTotal.AutoSize
                };
                cbBCount[i] = new ComboBox
                {
                    Location = new Point(cbBCountTotal.Location.X, cbBCountTotal.Location.Y + cbDiffY * (i+1)),
                    DropDownStyle = cbBCountTotal.DropDownStyle,
                    Size = cbBCountTotal.Size,
                    TabIndex = cbBCountTotal.TabIndex + i + 1,
                };
                cbBCount[i].Items.Add(string.Empty);
                cbBCount[i].Items.AddRange(varList());
                cbBCount[i].Text = hc.BonusCountHolder[i + 1];
                cbBCount[i].SelectedIndexChanged += CBChanged;

                Controls.Add(txtBCount[i]);
                Controls.Add(cbBCount[i]);
                Controls.Add(expBCount[i]);
            }

            // cb初期化
            cbInGame.Items.AddRange(varList());
            cbInGame.Text = hc.InGameHolder;
            cbInEffect.Items.Add(string.Empty);
            cbInEffect.Items.AddRange(varList());
            cbInEffect.Text = hc.LaunchEffect;
            cbBCountTotal.Items.Add(string.Empty);
            cbBCountTotal.Items.AddRange(varList());
            cbBCountTotal.Text = hc.BonusCountHolder[0];
            bConf = hc.BonusConfig;

            CBChanged(null, null);

            // dgv初期化
            builder = new DataBuilder.BonusConfigBuilder(btnAdd, btnMod, btnDel, btnSeekUp, btnSeekDn, dgvShow, bConf);
        }
        public bool SetData(Data.HistoryConfig hc)
        {
            hc.InGameHolder = cbInGame.Text;
            hc.LaunchEffect = cbInEffect.Text;
            hc.BonusCountHolder[0] = cbBCountTotal.Text;
            for (int i = 0; i < Data.HistoryConfig.BONUS_TYPE_MAX; ++i)
                hc.BonusCountHolder[i + 1] = cbBCount[i].Text;
            hc.BonusConfig = bConf;
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (cbInGame.SelectedIndex < 0)
            {
                MessageBox.Show(txtInGame.Text + "を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // InEffect, BCountは確認しない: 代入しない選択肢あり
            base.BtnOK_Click(sender, e);
        }
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }
        private void CBChanged(object sender, EventArgs e)
        {
            var baseData = Singleton.EffectDataManagerSingleton.GetInstance();
            expInGame.Text = txtInGame.Text + ": " + baseData.VarList.GetData(cbInGame.Text)?.usage;
            expInEffect.Text = txtInEffect.Text + ": " + baseData.VarList.GetData(cbInEffect.Text)?.usage;
            expBCountTotal.Text = txtBCountTotal.Text + ": " + baseData.VarList.GetData(cbBCountTotal.Text)?.usage;

            for (int i = 0; i < Data.HistoryConfig.BONUS_TYPE_MAX; ++i)
                expBCount[i].Text = txtBCount[i].Text + ": " + baseData.VarList.GetData(cbBCount[i].Text)?.usage;
        }
    }
}
