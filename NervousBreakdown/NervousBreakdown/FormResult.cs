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
        public string text { get; set; }

        public FormResult()
        {
            InitializeComponent();
        }

        //FormResult起動時
        private void FormResult_Load(object sender, EventArgs e)
        {
            //TurnLabelに受け取ったターン数を表示
            TurnLabel.Text = text;
        }

        private void FormResult_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TurnLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormResult_Load_1(object sender, EventArgs e)
        {

        }
    }
}
