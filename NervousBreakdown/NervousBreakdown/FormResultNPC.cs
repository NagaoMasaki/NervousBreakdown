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
    public partial class FormResultNPC : Form
    {
        FormMainNPC formMainNPC;

        //枚数の変数
        private int p_Point = 0;
        private int n_Point = 0;

        public void GetFormMain(FormMainNPC FormMainNPC)
        {
            this.formMainNPC = FormMainNPC;
        }

        //枚数取得
        public void GetPoint(int playerCount, int npcCount)
        {
            this.p_Point = playerCount;
            this.n_Point = npcCount;
        }

        //FormMainから受け取る
        public String text { get; set; }

        public FormResultNPC()
        {
            InitializeComponent();
        }

        private void FormResultNPC_Load(object sender, EventArgs e)
        {
            //それぞれの枚数と名前を表示する
            playerPoint.Text = p_Point.ToString();
            npcPoint.Text = n_Point.ToString();
            playerLabel.Text = text;

            //プレイヤーとNPCの枚数によって勝敗を決める
            if (p_Point > n_Point)
            {
                ResultLabel.Text = "勝ち";
            }
            else if (p_Point < n_Point)
            {
                ResultLabel.Text = "負け";
            }
            else
            {
                ResultLabel.Text = "引き分け";
            }
        }

        private void FormResultNPC_MouseClick(object sender, MouseEventArgs e)
        {
            formMainNPC.Close();
            this.Close();
            //アプリケーションを終了する
            Application.Exit();
        }
    }
}
