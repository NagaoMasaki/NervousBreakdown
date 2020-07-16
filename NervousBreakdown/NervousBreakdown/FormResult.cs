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
    public partial class FormResult : Form
    {
        //ランキングオブジェクトの作成
        public Ranking ranking = new Ranking();
        //カウント変数
        //private int count;

        FormMain formMain;

        FormMainNPC formMainNPC;

        public void GetFormMain(FormMain FormMain)
        {
            this.formMain = FormMain;
        }

        public void GetFormMainNPC(FormMainNPC FormMainNPC)
        {
            this.formMainNPC = FormMainNPC;
        }

        //カウント取得
        public void GetCount(int cou)
        {
            //this.count = cou;
        }

        //FormMainから受け取る
        public String text { get; set; }
        public int count { get; set; }
        public FormResult()
        {
            InitializeComponent();

            
        }

        //FormResult起動時
        private void FormResult_Load(object sender, EventArgs e)
        {
            //ランキングTextに追加
            ranking.Add(text, count);

            //名前とカウントの情報を持つPlayerDataクラスのリストを作成
            List<PlayerData> playerDatas = new List<PlayerData>();
            //ランキングデータを読み込む
            playerDatas = ranking.Read();
            //リストからランキング情報を取り出す
            label11.Text = playerDatas[0].GetName();
            label16.Text = playerDatas[0].GetCount().ToString();

            if (playerDatas[1].GetName() != null)
            {
                label12.Text = playerDatas[1].GetName();
                label17.Text = playerDatas[1].GetCount().ToString();
            }

            if (playerDatas[2].GetName() != null)
            {
                label13.Text = playerDatas[2].GetName();
                label18.Text = playerDatas[2].GetCount().ToString();
            }

            if (playerDatas[3].GetName() != null)
            {
                label14.Text = playerDatas[3].GetName();
                label19.Text = playerDatas[3].GetCount().ToString();
            }

            if (playerDatas[4].GetName() != null)
            {
                label15.Text = playerDatas[4].GetName();
                label20.Text = playerDatas[4].GetCount().ToString();
            }

            TurnResultLabel.Text = count.ToString();

           

            //foreach (PlayerData playerData in playerDatas)
            //{
            //    RankLabel.Text += playerData.GetName() + playerData.GetCount() + Environment.NewLine;
            //}
        }

        //画面をクリックしたとき
        private void FormResult_MouseClick(object sender, MouseEventArgs e)
        {
            formMain.Close();
            this.Close();
            //アプリケーションを終了する
            Application.Exit();
        }


        //勝敗判定を受け取る(仮)
        //public void JudgeResult(bool b)
        //{

        //}


    }
}
