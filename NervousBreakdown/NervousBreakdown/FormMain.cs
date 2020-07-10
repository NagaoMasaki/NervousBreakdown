using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NervousBreakdown
{
    public partial class FormMain : Form
    {
        Player player = new Player();
        Card card = new Card();
        Judge judge = new Judge();
        Count count = new Count();
        FormResult formResult = new FormResult();

        private PictureBox[] PictureArray = new PictureBox[53];

        private bool drawFlag = false;
        private bool twoDrawFlag = false;

        private bool[] cardFlag = new bool[53];

        bool j_hit = false;
        private int drawCount = 0;

        public FormTitle formTitle { get; set; }

        //FormTitleから受け取る
        public String nameText { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //デバック用
            this.NameLabel.Text = nameText;

            //デッキをシャッフルする
            card.CardMark();

            PictureArray[0] = this.CardBox1;
            PictureArray[1] = this.CardBox2;
            PictureArray[2] = this.CardBox3;
            PictureArray[3] = this.CardBox4;
            PictureArray[4] = this.CardBox5;
            PictureArray[5] = this.CardBox6;
            PictureArray[6] = this.CardBox7;
            PictureArray[7] = this.CardBox8;
            PictureArray[8] = this.CardBox9;
            PictureArray[9] = this.CardBox10;
            PictureArray[10] = this.CardBox11;
            PictureArray[11] = this.CardBox12;
            PictureArray[12] = this.CardBox13;
            PictureArray[13] = this.CardBox14;
            PictureArray[14] = this.CardBox15;
            PictureArray[15] = this.CardBox16;
            PictureArray[16] = this.CardBox17;
            PictureArray[17] = this.CardBox18;
            PictureArray[18] = this.CardBox19;
            PictureArray[19] = this.CardBox20;
            PictureArray[20] = this.CardBox21;
            PictureArray[21] = this.CardBox22;
            PictureArray[22] = this.CardBox23;
            PictureArray[23] = this.CardBox24;
            PictureArray[24] = this.CardBox25;
            PictureArray[25] = this.CardBox26;
            PictureArray[26] = this.CardBox27;
            PictureArray[27] = this.CardBox28;
            PictureArray[28] = this.CardBox29;
            PictureArray[29] = this.CardBox30;
            PictureArray[30] = this.CardBox31;
            PictureArray[31] = this.CardBox32;
            PictureArray[32] = this.CardBox33;
            PictureArray[33] = this.CardBox34;
            PictureArray[34] = this.CardBox35;
            PictureArray[35] = this.CardBox36;
            PictureArray[36] = this.CardBox37;
            PictureArray[37] = this.CardBox38;
            PictureArray[38] = this.CardBox39;
            PictureArray[39] = this.CardBox40;
            PictureArray[40] = this.CardBox41;
            PictureArray[41] = this.CardBox42;
            PictureArray[42] = this.CardBox43;
            PictureArray[43] = this.CardBox44;
            PictureArray[44] = this.CardBox45;
            PictureArray[45] = this.CardBox46;
            PictureArray[46] = this.CardBox47;
            PictureArray[47] = this.CardBox48;
            PictureArray[48] = this.CardBox49;
            PictureArray[49] = this.CardBox50;
            PictureArray[50] = this.CardBox51;
            PictureArray[51] = this.CardBox52;

            //デバック用
            //HitLabel.Text = drawFlag.ToString();
        }

        /// <summary>
        /// カードをクリックしたら表向きする関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Card_Click(object sender, EventArgs e)
        {
          

            if(drawFlag == false || twoDrawFlag == false)
            {
                for (int i = 0; i < PictureArray.Length; i++)
                {
                    if (sender.Equals(PictureArray[i]))
                    {
                        //カードの画像を表示
                        PictureArray[i].Image = SetImage(card.decks[i]);

                        //カードが裏向きか
                        if (cardFlag[i] == false)
                        {
                            j_hit = judge.Judgement(drawFlag, card.decks[i]);
                            player.Select(drawFlag, card.decks[i]);

                            //カードを一枚引いているなら
                            if (drawFlag == true)
                            {
                                //二枚目を引いた判定にする
                                twoDrawFlag = true;
                            }
                            else
                            {
                                //一枚目を引いた判定にする
                                drawFlag = true;
                            }
                        }

                        //引いた判定にする
                        cardFlag[i] = true;
                    }
                }

            }

            //デバック用
            {
                int a = count.GetCount();

                HitLabel.Text = a.ToString();

            }
        }

        /// <summary>
        /// フォームをクリック関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Click(object sender, EventArgs e)
        {
            //二枚引いたならなら
            if (drawFlag == true && twoDrawFlag == true)
            {
                drawCount++;

                label1.Text = drawCount.ToString();

                if (j_hit == true)
                {
                    //同じ数字の時
                    PlayBase();

                    int c = count.GetCount();

                    if(c == 26)
                    {
                        formResult.text = nameText;
                        formResult.Show();
                        formResult.GetCount(drawCount);
                        formResult.GetFormMain(this);
                        //終了
                        //this.Close();
                        this.Visible = false;
                    }
                }
                else
                {
                    //違う数字の時
                    ResetBasa();
                }

                drawFlag = false;
                twoDrawFlag = false;

                //デバック用
                {
                    int a = count.GetCount();

                    HitLabel.Text = a.ToString();

                }
            }
        }


        /// <summary>
        /// カードを消す関数
        /// </summary>
        public void PlayBase()
        {
            //カウントを増やす
            count.AddCount();

            for (int i = 0; i < cardFlag.Length; i++)
            {
                //カードが表向きなら
                if (cardFlag[i] == true)
                {
                    //画像を消す
                    PictureArray[i].Visible = false;
                }
            }
        }


        /// <summary>
        /// カードをリセットする関数
        /// </summary>
        public void ResetBasa()
        {
            //手札リセット
            player.Reset();

            for (int i = 0; i < cardFlag.Length; i++)
            {
                //カードが表向きなら
                if (cardFlag[i] == true)
                {
                    //裏向きにする
                    cardFlag[i] = false;

                    //画像を裏向き
                    PictureArray[i].Image = SetImage(53);
                }
            }
        }


        public Image SetImage(int s)
        {
            Image image = NervousBreakdown.Properties.Resources.card;
            switch (s)
            {
                case 1:
                    image = NervousBreakdown.Properties.Resources._1;
                    break;
                case 2:
                    image = NervousBreakdown.Properties.Resources._2;
                    break;
                case 3:
                    image = NervousBreakdown.Properties.Resources._3;
                    break;
                case 4:
                    image = NervousBreakdown.Properties.Resources._4;
                    break;
                case 5:
                    image = NervousBreakdown.Properties.Resources._5;
                    break;
                case 6:
                    image = NervousBreakdown.Properties.Resources._6;
                    break;
                case 7:
                    image = NervousBreakdown.Properties.Resources._7;
                    break;
                case 8:
                    image = NervousBreakdown.Properties.Resources._8;
                    break;
                case 9:
                    image = NervousBreakdown.Properties.Resources._9;
                    break;
                case 10:
                    image = NervousBreakdown.Properties.Resources._10;
                    break;
                case 11:
                    image = NervousBreakdown.Properties.Resources._11;
                    break;
                case 12:
                    image = NervousBreakdown.Properties.Resources._12;
                    break;
                case 13:
                    image = NervousBreakdown.Properties.Resources._13;
                    break;
                case 14:
                    image = NervousBreakdown.Properties.Resources._14;
                    break;
                case 15:
                    image = NervousBreakdown.Properties.Resources._15;
                    break;
                case 16:
                    image = NervousBreakdown.Properties.Resources._16;
                    break;
                case 17:
                    image = NervousBreakdown.Properties.Resources._17;
                    break;
                case 18:
                    image = NervousBreakdown.Properties.Resources._18;
                    break;
                case 19:
                    image = NervousBreakdown.Properties.Resources._19;
                    break;
                case 20:
                    image = NervousBreakdown.Properties.Resources._20;
                    break;
                case 21:
                    image = NervousBreakdown.Properties.Resources._21;
                    break;
                case 22:
                    image = NervousBreakdown.Properties.Resources._22;
                    break;
                case 23:
                    image = NervousBreakdown.Properties.Resources._23;
                    break;
                case 24:
                    image = NervousBreakdown.Properties.Resources._24;
                    break;
                case 25:
                    image = NervousBreakdown.Properties.Resources._25;
                    break;
                case 26:
                    image = NervousBreakdown.Properties.Resources._26;
                    break;
                case 27:
                    image = NervousBreakdown.Properties.Resources._27;
                    break;
                case 28:
                    image = NervousBreakdown.Properties.Resources._28;
                    break;
                case 29:
                    image = NervousBreakdown.Properties.Resources._29;
                    break;
                case 30:
                    image = NervousBreakdown.Properties.Resources._30;
                    break;
                case 31:
                    image = NervousBreakdown.Properties.Resources._31;
                    break;
                case 32:
                    image = NervousBreakdown.Properties.Resources._32;
                    break;
                case 33:
                    image = NervousBreakdown.Properties.Resources._33;
                    break;
                case 34:
                    image = NervousBreakdown.Properties.Resources._34;
                    break;
                case 35:
                    image = NervousBreakdown.Properties.Resources._35;
                    break;
                case 36:
                    image = NervousBreakdown.Properties.Resources._36;
                    break;
                case 37:
                    image = NervousBreakdown.Properties.Resources._37;
                    break;
                case 38:
                    image = NervousBreakdown.Properties.Resources._38;
                    break;
                case 39:
                    image = NervousBreakdown.Properties.Resources._39;
                    break;
                case 40:
                    image = NervousBreakdown.Properties.Resources._40;
                    break;
                case 41:
                    image = NervousBreakdown.Properties.Resources._41;
                    break;
                case 42:
                    image = NervousBreakdown.Properties.Resources._42;
                    break;
                case 43:
                    image = NervousBreakdown.Properties.Resources._43;
                    break;
                case 44:
                    image = NervousBreakdown.Properties.Resources._44;
                    break;
                case 45:
                    image = NervousBreakdown.Properties.Resources._45;
                    break;
                case 46:
                    image = NervousBreakdown.Properties.Resources._46;
                    break;
                case 47:
                    image = NervousBreakdown.Properties.Resources._47;
                    break;
                case 48:
                    image = NervousBreakdown.Properties.Resources._48;
                    break;
                case 49:
                    image = NervousBreakdown.Properties.Resources._49;
                    break;
                case 50:
                    image = NervousBreakdown.Properties.Resources._50;
                    break;
                case 51:
                    image = NervousBreakdown.Properties.Resources._51;
                    break;
                case 52:
                    image = NervousBreakdown.Properties.Resources._52;
                    break;
                case 53:
                    image = NervousBreakdown.Properties.Resources.card;
                    break;
            }
            return image;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            formTitle.Close();
        }
    }
}
