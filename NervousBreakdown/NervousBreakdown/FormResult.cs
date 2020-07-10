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
        public int count = 0;

        FormMain formMain;

        public void GetFormMain(FormMain FormMain)
        {
            this.formMain = FormMain;
        }

        //カウント取得
        public void GetCount(int cou)
        {
            this.count = cou;
        }

        //FormMainから受け取る
        public String text { get; set; }

        public FormResult()
        {
            InitializeComponent();

            
        }

        //FormResult起動時
        private void FormResult_Load(object sender, EventArgs e)
        {
            TurnResultLabel.Text = count.ToString();

            //ランキングTextに追加
            ranking.Add(text, count);

            //名前とカウントの情報を持つPlayerDataクラスのリストを作成
            List<PlayerData> playerDatas = new List<PlayerData>();
            //ランキングデータを読み込む
            playerDatas = ranking.Read();
            //リストからランキング情報を取り出す
            foreach (PlayerData playerData in playerDatas)
            {
                RankLabel.Text += playerData.GetName() + playerData.GetCount() + Environment.NewLine;
            }


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
