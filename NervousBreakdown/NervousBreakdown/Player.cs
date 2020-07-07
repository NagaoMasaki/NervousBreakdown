using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NervousBreakdown
{
    public class Player
    {
        //選んだ二枚のカードを保存
        private int[] open = new int[2];
        //選んだカードを一枚目と二枚目に分ける関数
        public void Select(bool p, int n)
        {
            switch (p)
            {
                //boolがfalseなら0に、trueなら1に入れる
                case false: open[0] = n; break;
                case true: open[1] = n; break;
            }
        }


        //カードの情報(数字)を受け取る関数
        public int[] Infomation()
        {
            return open;
        }

        //引き終わった後open[]の中身をリセットする関数
        public void Reset()
        {
            open[0] = 0;
            open[1] = 0;
        }

        public void Cpu()
        {
            for (int i = 0; i < 2;i++)
            {
                Random random = new Random();
                //カードを引く
                int cpuCard = random.Next(0, 51);
                //引いたカードかどうかチェック
                bool drawn =drawnCard;
                //まだ引いてないカードが出るまで引く
                while (drawn)
                {
                    cpuCard = random.Next(0, 51);
                    drawn =drawnCard;
                }
                //引いたカードを格納
                open[i] = cpuCard;
            }
        }
    }
}
