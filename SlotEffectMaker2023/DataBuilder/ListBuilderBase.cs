using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace SlotMaker2022
{
    public abstract class ListBuilderBase<DataClass, IndicatorClass> where DataClass : new() where IndicatorClass : new()
    {
        // 必要なボタン一覧 コンストラクタで引数指定する
        private Button AddButton;
        private Button ModButton;
        private Button DelButton;
        private Button SeekUpButton;
        private Button SeekDownButton;

        private int IndicatorPosition;
        // 直前に行ったswapの情報を記録する
        protected int SwapSrc;  // -1でswap無効
        protected int SwapDst;  // -1でデータ削除

        // 必要な描画用DataGridViewとForm
        protected DataGridView DGView;
        protected List<DataClass> Data;
        protected BindingList<IndicatorClass> Indicator;
        // private ListBuildFormBase<DataClass> FormDataMaker;

        // 必要なメソッド
        protected abstract void StartAdd(object sender, EventArgs e);
        protected abstract void StartMod(object sender, EventArgs e);
        protected abstract void UpdateIndicator(int indexShift);

        // 定義済みメソッド
        public ListBuilderBase(Button pAdd, Button pMod, Button pDel, Button pUp, Button pDown, DataGridView pDGView, List<DataClass> pData)
        {
            AddButton = pAdd;
            ModButton = pMod;
            DelButton = pDel;
            SeekUpButton = pUp;
            SeekDownButton = pDown;
            DGView = pDGView;
            Data = pData;
            Indicator = new BindingList<IndicatorClass>();

            IndicatorPosition = 0;
            SwapSrc = -1;
            SwapDst = -1;

            AddButton.Click += StartAdd;
            ModButton.Click += StartMod;
            DelButton.Click += StartDel;
            SeekUpButton.Click += SeekUp;
            SeekDownButton.Click += SeekDown;

            DGView.DataSource = Indicator;
            for (int i = 0; i < DGView.Columns.Count; ++i)
            {
                DGView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        protected virtual void StartDel(object sender, EventArgs e)
        {
            bool update = false;
            SwapDst = -1;
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                DialogResult rst = MessageBox.Show("選択中のデータを削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (rst == DialogResult.Yes)
                {
                    SwapSrc = row.Index;
                    Data.RemoveAt(row.Index);
                    update = true;
                }
                else
                {
                    SwapSrc = -1;
                }
            }
            if (update) UpdateIndicator(-1);
        }
        protected virtual void SeekUp(object sender, EventArgs e)
        {
            bool update = false;
            DataClass buf;
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                SwapSrc = row.Index;
                SwapDst = row.Index - 1;
                if (SwapDst < 0)
                {
                    SwapSrc = -1;
                    SwapDst = -1;
                    continue;
                }

                buf = Data[SwapSrc];
                Data[SwapSrc] = Data[SwapDst];
                Data[SwapDst] = buf;
                update = true;
            }
            if (update) UpdateIndicator(-1);
        }
        protected virtual void SeekDown(object sender, EventArgs e)
        {
            bool update = false;
            DataClass buf;
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                SwapSrc = row.Index;
                SwapDst = row.Index + 1;
                if (SwapDst >= Data.Count)
                {
                    SwapSrc = -1;
                    SwapDst = -1;
                    continue;
                }

                buf = Data[SwapSrc];
                Data[SwapSrc] = Data[SwapDst];
                Data[SwapDst] = buf;
                update = true;
            }
            if (update) UpdateIndicator(1);

        }

        // 関数渡しにてデータを自動設定する関数(新規生成の場合はindexにマイナス値を入れる)
        // 必要に応じて書き換え可能なようvirtual関数としておく
        protected virtual void SetData(int index, Func<DataClass, bool> pSetMethod)
        {
            DataClass newData = new DataClass();
            pSetMethod(newData);
            if (index < 0) Data.Add(newData);
            else Data[index] = newData;
            UpdateIndicator(0);
        }
        protected void InitIndicator()
        {
            // 前回選択位置取得
            foreach (DataGridViewRow row in DGView.SelectedRows)
            {
                IndicatorPosition = row.Index;
                break;
            }

            Indicator.Clear();
        }
        protected void FinalizeIndicator(int indexShift)
        {
            // 選択位置復元・表示位置決定
            if (IndicatorPosition >= 0 && Indicator.Count > 0)
            {
                int newReference = IndicatorPosition + indexShift;
                if (newReference < 0) newReference = 0;
                if (newReference >= Indicator.Count) newReference = Indicator.Count - 1;
                DGView.CurrentCell = DGView.Rows[newReference].Cells[0];

                int newPosition = newReference - 3;
                if (newPosition < 0) newPosition = 0;
                DGView.FirstDisplayedScrollingRowIndex = newPosition;
            }

            DGView.Refresh();
        }
        protected void AllLock(bool enabled)
        {
            AddButton.Enabled = enabled;
            ModButton.Enabled = enabled;
            DelButton.Enabled = enabled;
            SeekUpButton.Enabled = enabled;
            SeekDownButton.Enabled = enabled;
        }
        protected void ItemLock(bool enabled)
        {
            AddButton.Enabled = enabled;
            DelButton.Enabled = enabled;
            SeekUpButton.Enabled = enabled;
            SeekDownButton.Enabled = enabled;
        }
        protected void SwapLock(bool enabled)
        {
            DelButton.Enabled = enabled;
            SeekUpButton.Enabled = enabled;
            SeekDownButton.Enabled = enabled;
        }
        protected virtual void ShowDeleteError(string dataName, List<int> dependencies)
        {
            string depID = "";
            for (int i = 0; i < dependencies.Count; ++i)
            {
                if (i != 0) depID += ", ";
                depID += (dependencies[i] + 1).ToString();
            }
            depID = dataName + "との依存を解決してください。" + Environment.NewLine + "Index: " + depID;
            MessageBox.Show(depID, "削除失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        protected void ModifyDeny()
        {
            string msg = "このデータは編集・削除できません。";
            MessageBox.Show(msg, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
