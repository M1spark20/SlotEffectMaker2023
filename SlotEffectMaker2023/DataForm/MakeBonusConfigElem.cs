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
    public partial class MakeBonusConfigElem : SlotMaker2022.UserControl.FormElemDecide
    {
        public MakeBonusConfigElem(Data.BonusConfig bc)
        {
            InitializeComponent();
            if (bc == null) bc = new Data.BonusConfig();
            // コントロール初期化
            for (int i = 1; i < SlotMaker2022.LocalDataSet.BONUSFLAG_MAX; ++i) cbBonusID.Items.Add(i);
            for (int i = 0; i < SlotMaker2022.LocalDataSet.SYMBOL_MAX; ++i) cbSymbolID.Items.Add(i);
            for (int i = 1; i <= Data.HistoryConfig.BONUS_TYPE_MAX; ++i) cbTypeID.Items.Add(i);
            cbBonusID.Text = bc.BonusID.ToString();
            cbSymbolID.Text = bc.ComaID.ToString();
            cbTypeID.Text = bc.BonusType.ToString();
        }
        public bool SetData(Data.BonusConfig bc)
        {
            bc.BonusID   = byte.Parse(cbBonusID.Text);
            bc.ComaID    = byte.Parse(cbSymbolID.Text);
            bc.BonusType = byte.Parse(cbTypeID.Text);
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            if (cbBonusID.SelectedIndex < 0)
            {
                MessageBox.Show("ボーナスIDを設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbSymbolID.SelectedIndex < 0)
            {
                MessageBox.Show("履歴シンボルIDを設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbTypeID.SelectedIndex < 0)
            {
                MessageBox.Show("ボーナスカウント種別を設定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            base.BtnOK_Click(sender, e);
        }
        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }
    }
}
