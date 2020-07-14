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
        FormMain formMain;

        //枚数の変数
        public int playerMaisu = 0;
        public int npcMaisu = 0;

        public void GetFormMain(FormMain FormMain)
        {
            this.formMain = FormMain;
        }

        //枚数取得
        public void GetMaisu(int playerCount, int npcCount)
        {
            this.playerMaisu = playerCount;
            this.playerMaisu = npcCount;
        }

        //FormMainから受け取る
        public String text { get; set; }

        public FormResultNPC()
        {
            InitializeComponent();
        }

        private void FormResultNPC_Load(object sender, EventArgs e)
        {
            maisu1.Text = playerMaisu.ToString();
            maisu.Text = npcMaisu.ToString();
            player.Text =text;

            if (playerMaisu > npcMaisu)
            {
                shohai.Text = "勝ち";
            }
            else if (playerMaisu < npcMaisu)
            {
                shohai.Text = "負け";
            }
            else
            {
                shohai.Text = "引き分け";
            }

        }
        private void FormResultNPC_MouseClick(object sender, MouseEventArgs e)
        {
            formMain.Close();
            this.Close();
            //アプリケーションを終了する
            Application.Exit();
        }
    }
}
