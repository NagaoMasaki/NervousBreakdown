using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Judge
{
    //2枚のカードを受け取る
    //public int[] card=new int[2];

    public bool Judgement(int[] Open)
    {
        if (Open[0] % 13 == Open[1] % 13)
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

