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
                FormMain formMain = new FormMain();
                //メインの名前用Textに代入
                formMain.nameText = NameBox.Text;
                //titleを終了させるためにmainに代入する
                formMain.formTitle = this;
                //タイトル終了
                this.Visible = false;

                //メイン開始
                formMain.Show();
            }
            else
            {
                //先攻
                //formMainNPCの作成
                FormMainNPC formMainNPC = new FormMainNPC();
                //メインの名前用Textに代入
                formMainNPC.nameText = NameBox.Text;
                //titleを終了させるためにmainに代入する
                formMainNPC.formTitle = this;
                //先攻を代入
                formMainNPC.firstORSecond = true;
                //タイトル終了
                this.Visible = false;
                //メインNPC開始
                formMainNPC.Show();
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
                //formMainNPCの作成
                FormMainNPC formMainNPC = new FormMainNPC();
                //メインの名前用Textに代入
                formMainNPC.nameText = NameBox.Text;
                //titleを終了させるためにmainに代入する
                formMainNPC.formTitle = this;
                //後攻を代入
                formMainNPC.firstORSecond = false;
                //タイトル終了
                this.Visible = false;
                //メインNPC開始
                formMainNPC.Show();

            }
        }
    }
}
