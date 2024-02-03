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
    public partial class MakeColorMap : SlotMaker2022.UserControl.FormElemDecide
    {
        // 編集用データ
        uint sizeW, sizeH, cardNum;
        List<int> nowImage;
        // 表示用データ
        uint showCardID;

        public MakeColorMap(Data.ColorMap cm, uint w, uint h)
        {
            InitializeComponent();
            if (cm == null) { cm = new Data.ColorMap(); cm.SetSize(w, h); } 

            // 内部初期化
            sizeW = cm.sizeW;
            sizeH = cm.sizeH;
            cardNum = cm.cardNum;
            nowImage = new List<int>();
            nowImage.AddRange(cm.mapData);
            showCardID = 0u;

            // コントロール初期化
            numTrigTime.Maximum = int.MaxValue;
            numTrigTime.Value = cm.beginTime;
            numLoopCnt.Value = cm.loopCount;
            numFactor.Value = (decimal)cm.scaleFactor;
            cbAnimType.SelectedIndex = (int)cm.speed;
            chkFade.Checked = cm.fadeFlag;
            cbReadDirection.SelectedIndex = 0;
            UpdateImage(null, null);
        }
        public bool SetData(Data.ColorMap cm)
        {
            cm.mapData.Clear(); // 大きさ再設定用に一度データクリア
            cm.SetSize(sizeW, sizeH);
            cm.fadeFlag = chkFade.Checked;
            cm.loopCount = decimal.ToUInt32(numLoopCnt.Value);
            cm.beginTime = decimal.ToInt32(numTrigTime.Value);
            cm.scaleFactor = decimal.ToSingle(numFactor.Value);
            cm.speed = (Data.ColorMapAccelation)cbAnimType.SelectedIndex;
            cm.AddMapData(nowImage);
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

        private void ReadImage(object sender, EventArgs e)
        {
            fdReadMap.Filter = "PNG Image Files|*.png";
            DialogResult dr = fdReadMap.ShowDialog();
            if (dr != DialogResult.OK) return;

            string fileName = fdReadMap.FileName;
            if (fileName == string.Empty) return;

            // データ読込
            Bitmap bitmap;
            try
            {
                bitmap = new Bitmap(fileName);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("読み込みに失敗しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // 画像サイズ照査
            if (bitmap.Width % sizeW > 0 || bitmap.Height % sizeH > 0)
            {
                MessageBox.Show("読込画像サイズがMapサイズに合致しません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bitmap.Dispose();
                return;
            }
            uint mapSize = (uint)(bitmap.Width * bitmap.Height);
            uint cardSize = sizeW * sizeH;
            cardNum = mapSize / cardSize;
            nowImage.Clear();

            // データセット
            uint lw = (uint)(bitmap.Width / sizeW);
            uint lh = (uint)(bitmap.Height / sizeH);
            bool readDirX = cbReadDirection.Text == "X";
            for (uint pos = 0; pos < mapSize; ++pos)
            {
                // 読み取り位置設定
                uint cardID = pos / cardSize;
                uint posID = pos % cardSize;
                uint x = sizeW * ( readDirX ? cardID % lw : cardID / lh);
                uint y = sizeH * (!readDirX ? cardID % lh : cardID / lw);
                x += posID % sizeW;
                y += posID / sizeW;
                // 色読み取り
                nowImage.Add(bitmap.GetPixel((int)x, (int)y).ToArgb());
            }

            // 表示
            showCardID = 0;
            UpdateImage(sender, e);
            bitmap.Dispose();
        }
        private void ExportImage(object sender, EventArgs e)
        {
            if (cardNum == 0)
            {
                MessageBox.Show("データがありません。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // データ保存先指定
            fdSaveMap.Filter = "PNG Image Files|*.png";
            if (fdSaveMap.ShowDialog() != DialogResult.OK) return;

            // データ生成
            bool dirX = sizeW <= sizeH;
            int w = (int)sizeW * ( dirX ? (int)cardNum : 1);
            int h = (int)sizeH * (!dirX ? (int)cardNum : 1);
            Bitmap sav = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(sav);
            for(uint card = 0; card < cardNum; ++card)
            {
                int x =  dirX ? (int)(sizeW * card) : 0;
                int y = !dirX ? (int)(sizeH * card) : 0;
                Bitmap cardImg = GetImage(card, 1);
                g.DrawImage(cardImg, x, y, cardImg.Width, cardImg.Height);
            }

            // データ保存
            try
            {
                sav.Save(fdSaveMap.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("書込みに失敗しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void UpdateImage(object sender, EventArgs e)
        {
            if (cardNum == 0) { txtCardShow.Text = "X / X"; return; }
            txtCardShow.Text = (showCardID+1).ToString() + " / " + cardNum.ToString();
            picCardImg.Image = GetImage(showCardID, decimal.ToInt32(numExtRate.Value));
        }
        private void MinusCard(object sender, EventArgs e)
        {
            if (showCardID > 0) { --showCardID; UpdateImage(sender, e); }
        }
        private void PlusCard(object sender, EventArgs e)
        {
            if (showCardID + 1 < cardNum) { ++showCardID; UpdateImage(sender, e); }
        }

        private Bitmap GetImage(uint cardID, int rate)
        {   // 表示用、または保存用の画像を作成する
            if (cardID >= cardNum) return null;
            Bitmap raw = new Bitmap((int)sizeW, (int)sizeH);
            Bitmap ans = new Bitmap((int)sizeW * rate, (int)sizeH * rate);
            // データセット
            for (uint pos = 0; pos < sizeW * sizeH; ++pos)
            {
                // 読み取り位置設定
                uint x = pos % sizeW;
                uint y = pos / sizeW;
                // 色読み取り
                raw.SetPixel((int)x, (int)y, Color.FromArgb(nowImage[(int)(pos + cardID * sizeW * sizeH)]));
            }
            // nearestで拡大
            Graphics g = Graphics.FromImage(ans);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            g.DrawImage(raw, 0, 0, ans.Width, ans.Height);  // ansに自動反映される
            return ans;
        }
    }
}
