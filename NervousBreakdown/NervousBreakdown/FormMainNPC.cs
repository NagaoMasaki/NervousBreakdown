using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace NervousBreakdown
{
    public partial class FormMainNPC : Form
    {
        Player player = new Player();
        Card card = new Card();
        Judge judge = new Judge();
        FormResultNPC formResultNPC = new FormResultNPC();

        //画像
        private PictureBox[] PictureArray = new PictureBox[52];

        //一枚目を引いたか判定
        private bool drawFlag = false;

        //二枚目を引いたか判定
        private bool twoDrawFlag = false;

        private bool[] cpuMemory = new bool[52];

        //カードをが表になったか判定
        private bool[] cardFlag = new bool[52];

        //ジャッジの判定を貰う変数
        bool j_hit = false;

        //NPCのターン判定
        bool npcTurn = false;

        //プレイヤーの得点
        private int playerPoint = 0;

        //NPCの得点
        private int npcPoint = 0;

        public FormTitle formTitle { get; set; }

        //FormTitleから受け取る
        public String nameText { get; set; }

        //FormTitleから先攻後攻を受け取る true=先攻
        public bool firstORSecond { get; set; }

        public FormMainNPC()
        {
            InitializeComponent();
        }

        private void FormMainNPC_Load(object sender, EventArgs e)
        {
            //名前のラベルに入力した名前を代入
            this.NameLabel.Text = nameText;

            //デッキをシャッフルする
            card.CardMark();

            //画像の情報をListに代入する
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

            //NPCが先攻か後攻か
            npcTurn = !firstORSecond;

            //NPCのターン中ループ
            while (npcTurn == true)
            {
                //NPCに切り替え
                NpcMove();
            }
        }

        /// <summary>
        /// カードをクリックしたら表向きする関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Card_Click(object sender, EventArgs e)
        {
            //カードを二枚引いたか
            if (drawFlag == false || twoDrawFlag == false)
            {
                //トランプの数分回す
                for (int i = 0; i < PictureArray.Length; i++)
                {
                    //クリックした画像か
                    if (sender.Equals(PictureArray[i]))
                    {
                        //カードの画像を表示
                        PictureArray[i].Image = SetImage(card.decks[i]);

                        //カードが裏向きか
                        if (cardFlag[i] == false)
                        {
                            //ジャッジクラスで判定
                            j_hit = judge.Judgement(drawFlag, card.decks[i]);

                            //プレイヤークラスにカードの情報を渡す
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
                        //CPUが覚える
                        cpuMemory[i] = true;
                    }
                }
            }
        }

        /// <summary>
        /// フォームをクリック関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMainNPC_Click(object sender, EventArgs e)
        {
            //二枚引いたならなら
            if (drawFlag == true && twoDrawFlag == true)
            {
                
                //成功したか
                if (j_hit == true)
                {
                    //同じ数字の時
                    GetPoint();

                    //プレイヤーとNPCの合計のポイントを持つ変数
                    int sum = playerPoint + npcPoint;

                    //26ペアそろったか？
                    if (sum == 26)
                    {
                        //リザルトに入力した名前を入れる
                        formResultNPC.text = nameText;

                        //プレイヤーとNPCのポイントをリザルトに送る
                        formResultNPC.GetPoint(playerPoint,npcPoint);

                        formResultNPC.GetFormMain(this);

                        formResultNPC.Show();

                        //メインの終了
                        this.Visible = false;
                        //リザルトの表示

                       
                    }
                }
                else
                {
                    //違う数字の時
                    ResetCard();

                    //NPCのターンにする
                    npcTurn = true;
                    //NPCTimer.Enabled = true;
                }

                //引いた判定をリセット
                drawFlag = false;
                twoDrawFlag = false;
            }

            //NPCのターン中ループ
            while (npcTurn == true)
            {
                //NPCに切り替え
                NpcMove();
            }
        }

        /// <summary>
        /// 得点の追加をしてカードを消す関数
        /// </summary>
        public void GetPoint()
        {
            //現在どちらのターンか
            if(npcTurn == false)
            {
                //プレイヤーのターン
                //プレイヤーに得点の追加
                playerPoint++;

                //画面にポイントの表示をする
                this.playerPointLabel.Text = playerPoint.ToString();
            }
            else
            {
                //NPCのターン
                //NPCに得点の追加
                npcPoint++;

                //画面にポイントの表示をする
                this.NPCPointLabel.Text = npcPoint.ToString();
            }

            for (int i = 0; i < cardFlag.Length; i++)
            {
                //カードが表向きなら
                if (cardFlag[i] == true)
                {
                    //画像を消す
                    PictureArray[i].Visible = false;
                    //CPUが忘れる
                    cpuMemory[i] = false;
                }
            }
        }


        /// <summary>
        /// 表向きのカードをリセットする関数
        /// </summary>
        public void ResetCard()
        {
            //手札リセット
            player.Reset();

            for (int i = 0; i < cardFlag.Length;i++)
            {
                if(cpuMemory[i] == true)
                {
                    cardFlag[i] = false;
                    // 裏向きにする
                    PictureArray[i].Image = SetImage(53);
                    PictureArray[i].Refresh();
                    cpuMemory[i] = false;
                }
            }            

           
        }


        /// <summary>
        /// 敵の操作関数
        /// </summary>
        private void NpcMove()
        {
            //ランダムで数字を取得
            int num = player.ReturnNum();

            //引いてない数字が出るまで回す
            while (cardFlag[num] == true)
            {
                //ランダムで数字を取得
                num = player.ReturnNum();
            }

            // カードが裏向きか
            if (cardFlag[num] == false)
            {
                //カードを表向き判定にする
                cardFlag[num] = true;

                //メモリーに記憶する
                cpuMemory[num] = true;　

                //カードの画像を表示
                PictureArray[num].Image = SetImage(card.decks[num]);
                PictureArray[num].Refresh();

                //ジャッジクラスで判定
                j_hit = judge.Judgement(drawFlag, card.decks[num]);

                //プレイヤークラスにカードの情報を渡す
                player.Select(drawFlag, card.decks[num]);

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

            //二枚引いたならなら
            if (drawFlag == true && twoDrawFlag == true)
            {
                //成功したか
                if (j_hit == true)
                {
                    //同じ数字の時
                    GetPoint();
                }
                else
                {
                    //違う数字の時
                    ResetCard();

                    //ターン終了
                    npcTurn = false;
                    //NPCTimer.Enabled = false;
                }

                //引いた判定をリセット
                drawFlag = false;
                twoDrawFlag = false;
            }
        }

        /// <summary>
        /// タイトルを消す関数
        /// </summary>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            formResultNPC.Close();
            formTitle.Close();
            Application.Exit();
        }

        /// <summary>
        /// タイマー関数
        /// </summary>
        private void NPCTimer_Tick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 引数から画像を見つける関数
        /// </summary>
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

 
    }
}
