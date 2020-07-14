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
    public partial class FormTitle : Form
    {
        FormMain formMain = new FormMain();

        //CPUのボタンを押したかどうかのフラグ
        private bool cpuButtonFlag = false;

        public FormTitle()
        {
            InitializeComponent();
        }

        private void OnePlayButton_Click(object sender, EventArgs e)
        {
            if(!cpuButtonFlag)
            {
                //メインの名前用Textに代入
                formMain.nameText = NameBox.Text;
                //titleを終了させるためにmainに代入する
                formMain.formTitle = this;
                //タイトル終了
                this.Visible = false;

                //メイン開始
                formMain.Show();
            }
            
            
            
        }

        private void CPUPlayButton_Click(object sender, EventArgs e)
        {
            if(!cpuButtonFlag)
            {
                //テキスト変更
                OnePlayButton.Text = "先攻";
                CPUPlayButton.Text = "後攻";
                //フラグを立てる
                cpuButtonFlag = true;
            }
            else
            {
                //後攻


            }
        }
    }
}
