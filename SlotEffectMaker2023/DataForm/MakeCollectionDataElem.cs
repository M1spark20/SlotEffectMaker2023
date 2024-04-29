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
    public partial class MakeCollectionDataElem : SlotMaker2022.UserControl.FormElemDecide
    {
        // 編集用データ
        Label[] title;
        Label[][] info;
        ComboBox[] ptn;
        SlotMaker2022.UserControl.NumericUpDown_AutoSelect[] comaID;
        SlotMaker2022.UserControl.NumericUpDown_AutoSelect[][] symbolID;

        const int REEL_SIZE = SlotMaker2022.LocalDataSet.REEL_MAX;
        const int SHOW_SIZE = SlotMaker2022.LocalDataSet.SHOW_MAX;

        public MakeCollectionDataElem(Data.CollectionDataElem de)
        {
            InitializeComponent();
            if (de == null) { de = new Data.CollectionDataElem(); }

            // データ追加・編集
            numComaID.Maximum = SlotMaker2022.LocalDataSet.COMA_MAX - 1;
            numSymbolID.Maximum = (1 << SlotMaker2022.LocalDataSet.SYMBOL_MAX) - 1;
            numSymbolID.Minimum = -numSymbolID.Maximum;

            // 内部初期化
            title = new Label[REEL_SIZE];
            info = new Label[REEL_SIZE][];
            ptn = new ComboBox[REEL_SIZE];
            comaID = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect[REEL_SIZE];
            symbolID = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect[REEL_SIZE][];
            for (int i = 0; i < REEL_SIZE; ++i)
            {
                info[i] = new Label[SHOW_SIZE];
                symbolID[i] = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect[SHOW_SIZE];
            }

            // コントロール初期値設定
            title[0] = txt1;
            info[0][0] = txtSymbol;
            ptn[0] = cbPtn;
            comaID[0] = numComaID;
            symbolID[0][0] = numSymbolID;

            // コントロール追加・データ入力
            string[] titleName = { "左リール定義", "中リール定義", "右リール定義" };
            string[] ptnName = { "ComaID", "SymbolID", "ANY", "回転中", "はずれ", "?" };
            numLevel.Value = de.Level;

            for (int i = 0; i < REEL_SIZE; ++i)
            {
                if (i > 0)
                {
                    title[i] = new Label
                    {
                        AutoSize = txt1.AutoSize,
                        Location = new Point(txt1.Location.X + 100 * i, txt1.Location.Y),
                        Text = titleName[i]
                    };
                    ptn[i] = new ComboBox
                    {
                        DropDownStyle = cbPtn.DropDownStyle,
                        Location = new Point(cbPtn.Location.X + 100 * i, cbPtn.Location.Y),
                        Size = cbPtn.Size,
                        TabIndex = cbPtn.TabIndex + 100 * i
                    };
                    comaID[i] = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect
                    {
                        Location = new Point(numComaID.Location.X + 100 * i, numComaID.Location.Y),
                        Minimum = numComaID.Minimum,
                        Maximum = numComaID.Maximum,
                        Size = numComaID.Size,
                        TextAlign = numComaID.TextAlign,
                        TabIndex = numComaID.TabIndex + 100 * i
                    };
                    this.Controls.Add(title[i]);
                    this.Controls.Add(ptn[i]);
                    this.Controls.Add(comaID[i]);
                }
                ptn[i].Items.AddRange(ptnName);
                ptn[i].SelectedIndex = (int)de.CollectionElem[i].Pattern;
                ptn[i].SelectedIndexChanged += DataEnable;
                comaID[i].Value = de.CollectionElem[i].ReelPos;

                for (int j = 0; j < SHOW_SIZE; ++j)
                {
                    if (i > 0 || j > 0)
                    {
                        info[i][j] = new Label()
                        {
                            AutoSize = txtSymbol.AutoSize,
                            Location = new Point(txtSymbol.Location.X + 100 * i, txtSymbol.Location.Y - 40 * j),
                            Text = txtSymbol.Text
                        };
                        symbolID[i][j] = new SlotMaker2022.UserControl.NumericUpDown_AutoSelect
                        {
                            Location = new Point(numSymbolID.Location.X + 100 * i, numSymbolID.Location.Y - 40 * j),
                            Minimum = numSymbolID.Minimum,
                            Maximum = numSymbolID.Maximum,
                            Size = numSymbolID.Size,
                            TextAlign = numSymbolID.TextAlign,
                            TabIndex = numSymbolID.TabIndex + 100 * i - j
                        };
                        this.Controls.Add(info[i][j]);
                        this.Controls.Add(symbolID[i][j]);
                    }
                    symbolID[i][j].Value = de.CollectionElem[i].ComaItem[j];
                    symbolID[i][j].ValueChanged += SymbolUpdate;
                }
            }
            SymbolUpdate(null, null);
            DataEnable(null, null);
        }
        public bool SetData(Data.CollectionDataElem de)
        {
            de.Level = decimal.ToByte(numLevel.Value);
            for (int i = 0; i < REEL_SIZE; ++i)
            {
                de.CollectionElem[i].Pattern = (Data.CollectionReelPattern)ptn[i].SelectedIndex;
                de.CollectionElem[i].ReelPos = decimal.ToByte(comaID[i].Value);
                for (int j = 0; j < SHOW_SIZE; ++j)
                {
                    de.CollectionElem[i].ComaItem[j] = decimal.ToInt16(symbolID[i][j].Value);
                }
            }
            return true;
        }
        protected override void BtnOK_Click(object sender, EventArgs e)
        {
            base.BtnOK_Click(sender, e);
        }

        protected override void BtnCancel_Click(object sender, EventArgs e)
        {
            base.BtnCancel_Click(sender, e);
        }

        private void SymbolUpdate(object sender, EventArgs e)
        {
            for (int i = 0; i < REEL_SIZE; ++i)
            {
                for (int j = 0; j < SHOW_SIZE; ++j)
                {
                    int val = decimal.ToInt32(Math.Abs(symbolID[i][j].Value));
                    string msg = string.Empty;
                    for (int v = 0; v < SlotMaker2022.LocalDataSet.SYMBOL_MAX; ++v)
                    {
                        msg += (val % 2 == 1) ? v.ToString() : "-";
                        val /= 2;
                    }
                    info[i][j].Text = msg;
                }
            }
        }

        private void DataEnable(object sender, EventArgs e)
        {
            for (int i = 0; i < REEL_SIZE; ++i)
            {
                comaID[i].Enabled = ptn[i].SelectedIndex == (int)Data.CollectionReelPattern.eReelPos;
                for (int j = 0; j < SHOW_SIZE; ++j)
                {
                    symbolID[i][j].Enabled = ptn[i].SelectedIndex == (int)Data.CollectionReelPattern.eComaItem;
                    info[i][j].Enabled = ptn[i].SelectedIndex == (int)Data.CollectionReelPattern.eComaItem;
                }
            }
        }
    }
}
