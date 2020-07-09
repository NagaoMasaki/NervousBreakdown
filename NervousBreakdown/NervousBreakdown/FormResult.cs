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


        //FormMainから受け取る
        public String text { get; set; }

        public FormResult()
        {
            InitializeComponent();
        }

        //画面をクリックしたとき
        private void FormResult_MouseClick(object sender, EventArgs e)
        {
            //アプリケーションを終了する
            Application.Exit();
        }

        //FormResult起動時
        private void FormResult_Load(object sender, EventArgs e)
        {
            TurnResultLabel.Text = text;
        }

        //勝敗判定を受け取る(仮)
        //public void JudgeResult(bool b)
        //{

        //}


    }
}
