using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NervousBreakdown
{
    class Card
    {
        Random rand = new System.Random();

        // 山札作成
        public int[] decks = new int[52];

        //ランダムで収納する関数
        public void CardMark()
        {
            //配列に数字を代入
            for (int i = 1; i < 53; i++)
            {
                decks[i - 1] = i;
            }


            //int n = decks.Length;

            ////山札に数字が全て入るまでループ
            //while (n > 1)
            //{
            //    n--;
            //    int k = rand.Next(n + 1);
            //    int tmp = decks[k];
            //    decks[k] = decks[n];
            //    decks[n] = tmp;
            //}
        }

    }
}