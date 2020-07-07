using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Judge
{
    //2枚のカードを受け取る
    private int[] card=new int[2];

    public bool Judgement(bool p, int draw)
    {
        switch(p)
        {
         //boolがfalseなら0に、trueなら1に入れる
           case false: card[0] = draw; break;
           case true: card[1] = draw; break;
        }



        if (card[0] % 13 == card[1] % 13　&& p == true)
        {
            //2枚のカードの数値が同じなら成功
            return true;
        }
        else
        {
            //2枚のカードの数値が違うなら失敗
            return false;
        }
    }
}

