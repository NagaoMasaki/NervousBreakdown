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
    public partial class FormMain : Form
    {
       
        public FormMain()
        {
            InitializeComponent();

            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// カードをクリックしたら表向きする関数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Card_Click(object sender, EventArgs e)
        {
            //クリックしたのはCardBox1か
            if (sender.Equals(this.CardBox1))
            {
                //カードの画像を表示
                this.CardBox1.Image = SetImage(1);
            }

            //クリックしたのはCardBox2
            if (sender.Equals(this.CardBox2))
            {
                //カードの画像を表示
                this.CardBox2.Image = SetImage(2);
            }

            //クリックしたのはCardBox3
            if (sender.Equals(this.CardBox3))
            {
                //カードの画像を表示
                this.CardBox3.Image = SetImage(3);
            }

            //クリックしたのはCardBox4か
            if (sender.Equals(this.CardBox4))
            {
                //カードの画像を表示
                this.CardBox4.Image = SetImage(4);
            }

            //クリックしたのはCardBox5
            if (sender.Equals(this.CardBox5))
            {
                //カードの画像を表示
                this.CardBox5.Image = SetImage(5);
            }

            //クリックしたのはCardBox6
            if (sender.Equals(this.CardBox6))
            {
                //カードの画像を表示
                this.CardBox6.Image = SetImage(6);
            }

            //クリックしたのはCardBo7か
            if (sender.Equals(this.CardBox7))
            {
                //カードの画像を表示
                this.CardBox7.Image = SetImage(7);
            }

            //クリックしたのはCardBox8
            if (sender.Equals(this.CardBox8))
            {
                //カードの画像を表示
                this.CardBox8.Image = SetImage(8);
            }

            //クリックしたのはCardBox9
            if (sender.Equals(this.CardBox9))
            {
                //カードの画像を表示
                this.CardBox9.Image = SetImage(9);
            }

            //クリックしたのはCardBox10か
            if (sender.Equals(this.CardBox10))
            {
                //カードの画像を表示
                this.CardBox10.Image = SetImage(10);
            }

            //クリックしたのはCardBox11
            if (sender.Equals(this.CardBox11))
            {
                //カードの画像を表示
                this.CardBox11.Image = SetImage(11);
            }

            //クリックしたのはCardBox12
            if (sender.Equals(this.CardBox12))
            {
                //カードの画像を表示
                this.CardBox12.Image = SetImage(12);
            }

            //クリックしたのはCardBox13
            if (sender.Equals(this.CardBox13))
            {
                //カードの画像を表示
                this.CardBox13.Image = SetImage(13);
            }

            //クリックしたのはCardBox14か
            if (sender.Equals(this.CardBox14))
            {
                //カードの画像を表示
                this.CardBox14.Image = SetImage(14);
            }

            //クリックしたのはCardBox15
            if (sender.Equals(this.CardBox15))
            {
                //カードの画像を表示
                this.CardBox15.Image = SetImage(15);
            }

            //クリックしたのはCardBox16
            if (sender.Equals(this.CardBox16))
            {
                //カードの画像を表示
                this.CardBox16.Image = SetImage(16);
            }

            //クリックしたのはCardBox17か
            if (sender.Equals(this.CardBox17))
            {
                //カードの画像を表示
                this.CardBox17.Image = SetImage(17);
            }

            //クリックしたのはCardBox18
            if (sender.Equals(this.CardBox18))
            {
                //カードの画像を表示
                this.CardBox18.Image = SetImage(18);
            }

            //クリックしたのはCardBox19
            if (sender.Equals(this.CardBox19))
            {
                //カードの画像を表示
                this.CardBox19.Image = SetImage(19);
            }

            //クリックしたのはCardBo20か
            if (sender.Equals(this.CardBox20))
            {
                //カードの画像を表示
                this.CardBox20.Image = SetImage(20);
            }

            //クリックしたのはCardBox21
            if (sender.Equals(this.CardBox21))
            {
                //カードの画像を表示
                this.CardBox21.Image = SetImage(21);
            }

            //クリックしたのはCardBox22
            if (sender.Equals(this.CardBox22))
            {
                //カードの画像を表示
                this.CardBox22.Image = SetImage(22);
            }

            //クリックしたのはCardBox23か
            if (sender.Equals(this.CardBox23))
            {
                //カードの画像を表示
                this.CardBox23.Image = SetImage(23);
            }

            //クリックしたのはCardBox24
            if (sender.Equals(this.CardBox24))
            {
                //カードの画像を表示
                this.CardBox24.Image = SetImage(24);
            }

            //クリックしたのはCardBox25
            if (sender.Equals(this.CardBox25))
            {
                //カードの画像を表示
                this.CardBox25.Image = SetImage(25);
            }

            //クリックしたのはCardBox26
            if (sender.Equals(this.CardBox26))
            {
                //カードの画像を表示
                this.CardBox26.Image = SetImage(26);
            }

            //クリックしたのはCardBox27か
            if (sender.Equals(this.CardBox27))
            {
                //カードの画像を表示
                this.CardBox27.Image = SetImage(27);
            }

            //クリックしたのはCardBox28
            if (sender.Equals(this.CardBox28))
            {
                //カードの画像を表示
                this.CardBox28.Image = SetImage(28);
            }

            //クリックしたのはCardBox29
            if (sender.Equals(this.CardBox29))
            {
                //カードの画像を表示
                this.CardBox29.Image = SetImage(29);
            }

            //クリックしたのはCardBox30
            if (sender.Equals(this.CardBox30))
            {
                //カードの画像を表示
                this.CardBox30.Image = SetImage(30);
            }

            //クリックしたのはCardBox31
            if (sender.Equals(this.CardBox31))
            {
                //カードの画像を表示
                this.CardBox31.Image = SetImage(31);
            }

            //クリックしたのはCardBox32
            if (sender.Equals(this.CardBox32))
            {
                //カードの画像を表示
                this.CardBox32.Image = SetImage(32);
            }

            //クリックしたのはCardBo33か
            if (sender.Equals(this.CardBox33))
            {
                //カードの画像を表示
                this.CardBox33.Image = SetImage(33);
            }

            //クリックしたのはCardBox34
            if (sender.Equals(this.CardBox34))
            {
                //カードの画像を表示
                this.CardBox34.Image = SetImage(34);
            }

            //クリックしたのはCardBox35
            if (sender.Equals(this.CardBox35))
            {
                //カードの画像を表示
                this.CardBox35.Image = SetImage(35);
            }

            //クリックしたのはCardBox36か
            if (sender.Equals(this.CardBox36))
            {
                //カードの画像を表示
                this.CardBox36.Image = SetImage(36);
            }

            //クリックしたのはCardBox37
            if (sender.Equals(this.CardBox37))
            {
                //カードの画像を表示
                this.CardBox37.Image = SetImage(37);
            }

            //クリックしたのはCardBox38
            if (sender.Equals(this.CardBox38))
            {
                //カードの画像を表示
                this.CardBox38.Image = SetImage(38);
            }

            //クリックしたのはCardBo39
            if (sender.Equals(this.CardBox39))
            {
                //カードの画像を表示
                this.CardBox39.Image = SetImage(39);
            }

            //クリックしたのはCardBox40
            if (sender.Equals(this.CardBox40))
            {
                //カードの画像を表示
                this.CardBox40.Image = SetImage(40);
            }

            //クリックしたのはCardBox41
            if (sender.Equals(this.CardBox41))
            {
                //カードの画像を表示
                this.CardBox41.Image = SetImage(41);
            }

            //クリックしたのはCardBox42
            if (sender.Equals(this.CardBox42))
            {
                //カードの画像を表示
                this.CardBox42.Image = SetImage(42);
            }

            //クリックしたのはCardBox43か
            if (sender.Equals(this.CardBox43))
            {
                //カードの画像を表示
                this.CardBox43.Image = SetImage(43);
            }

            //クリックしたのはCardBox44
            if (sender.Equals(this.CardBox44))
            {
                //カードの画像を表示
                this.CardBox44.Image = SetImage(44);
            }

            //クリックしたのはCardBox45
            if (sender.Equals(this.CardBox45))
            {
                //カードの画像を表示
                this.CardBox45.Image = SetImage(45);
            }

            //クリックしたのはCardBo20か
            if (sender.Equals(this.CardBox46))
            {
                //カードの画像を表示
                this.CardBox46.Image = SetImage(46);
            }

            //クリックしたのはCardBox47
            if (sender.Equals(this.CardBox47))
            {
                //カードの画像を表示
                this.CardBox47.Image = SetImage(47);
            }

            //クリックしたのはCardBox48
            if (sender.Equals(this.CardBox48))
            {
                //カードの画像を表示
                this.CardBox48.Image = SetImage(48);
            }

            //クリックしたのはCardBox49か
            if (sender.Equals(this.CardBox49))
            {
                //カードの画像を表示
                this.CardBox49.Image = SetImage(49);
            }

            //クリックしたのはCardBox50
            if (sender.Equals(this.CardBox50))
            {
                //カードの画像を表示
                this.CardBox50.Image = SetImage(50);
            }

            //クリックしたのはCardBox51
            if (sender.Equals(this.CardBox51))
            {
                //カードの画像を表示
                this.CardBox51.Image = SetImage(51);
            }

            //クリックしたのはCardBox52
            if (sender.Equals(this.CardBox52))
            {
                //カードの画像を表示
                this.CardBox52.Image = SetImage(52);
            }
        }

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
