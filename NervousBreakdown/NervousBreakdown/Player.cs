using System;
using System.Collections.Generic;
using System.Globalization;
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
        
        public void Cpu(bool[] cpuMemory,int[] decks)
        {
            Random random = new Random();
            //カードを引く
            int cpuCard = random.Next(0, 51);
            //引いたカードかどうかチェック
                    bool drawn = drawnCard;
                    //まだ引いてないカードが出るまで引く
                    while (drawn)
                    {
                        cpuCard = random.Next(0, 51);
                        drawn = drawnCard;
                    }
                    //ランダムな配列を探す
                    for (i = 0; i < 52; i++)
                    {
                        if (decks[i] == cpuCard)
                        {
                            //引いたカードを格納
                            open[0] = decks[i];
                            cpuMemory[i] = true;
                        }
                    }

            //一枚目に引いたカードが覚えてる数値と同じなら
            for (int j = 0; j < 52; j++)
            {
                if (cpuMemory[j] = true && decks[j] % 13 == open[0] % 13)
                {
                    open[1] = decks[j];
                }
                else
                {

                    Random random = new Random();
                    //カードを引く
                    int cpuCard2= random.Next(0, 51);
                    //引いたカードかどうかチェック
                    bool drawn = drawnCard;
                    //まだ引いてないカードが出るまで引く
                    while (drawn)
                    {
                        cpuCard2= random.Next(0, 51);
                        drawn = drawnCard;
                    }
                    //引いたカードを格納
                    open[1] = cpuCard2;
                }
            }
        }
    }
}
