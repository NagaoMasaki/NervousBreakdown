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

        public FormTitle()
        {
            InitializeComponent();
        }

        private void OnePlayButton_Click(object sender, EventArgs e)
        {
            //メインの名前用Textに代入
            formMain.nameText = NameBox.Text;
            //メイン開始
            formMain.Show();

            //タイトル終了
            this.Visible = false;
        }
    }
}
