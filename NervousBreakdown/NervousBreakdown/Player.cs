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

        /// <summary>
        /// 選んだカードを一枚目と二枚目に分ける関数
        /// </summary>
        /// <param name="p"></param>
        /// <param name="n"></param>
        public void Select(bool p, int n)
        {
            switch (p)
            {
                //boolがfalseなら0に、trueなら1に入れる
                case false: open[0] = n; break;
                case true: open[1] = n; break;
            }
        }


        /// <summary>
        /// カードの情報(数字)を受け取る関数
        /// </summary>
        /// <returns></returns>
        public int[] Infomation()
        {
            return open;
        }


        /// <summary>
        /// 引き終わった後open[]の中身をリセットする関数
        /// </summary>
        public void Reset()
        {
            open[0] = 0;
            open[1] = 0;
        }

        public int ReturnNum(List<int> cardList)
        {
            //ランダム生成
            Random random = new Random();
            //カードを引く
            int cpuCard = random.Next(0, cardList.Count());

            

            return cardList[cpuCard];
        }

        public void Cpu(int drawCardNum)
        {
            //どちらとも引いてないか
            if(open[0] == 0 && open[1] == 0)
            {
                //引いたカードを格納
                open[0] = drawCardNum;
            }
            //一枚目を引いたなら
            else
            {
                //引いたカードを格納
                open[1] = drawCardNum;
            }
        }
    }
}
