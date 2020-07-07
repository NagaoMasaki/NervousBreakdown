using System;

//カウントクラス
public class Count
{
    private int count = 0;      //カウント


    //コンストラクタ
    //Count()
    //{
    //    //初期化
    //    count = 0;
    //}

    //カウントを増やす
    public void AddCount()
    {
        //カウントを１増やす
        count++;
    }

    //カウントを取得
    public int GetCount()
    {
        //カウントを渡す
        return count;
    }

    //リセット
    public void Reset()
    {
        //カウントを0にする
        count = 0;
    }

}