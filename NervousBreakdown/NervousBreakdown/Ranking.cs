using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NervousBreakdown
{
    public class Ranking
    {
        List<string> lists = new List<string>();

        List<PlayerData> playerDatas = new List<PlayerData>();

        public void Add(string name, int count)
        {
            //テキストに値を追加
            File.AppendAllText(@"test.txt", name + "      " + ","  +Convert.ToString(count) + Environment.NewLine);
        }


        public List<PlayerData> Read()
        {
            //File.ReadAllText(@"test.txt");
            
            StreamReader sr = new StreamReader(@"test.txt");
            {
                
                while (!sr.EndOfStream)
                {
                   
                    string line = sr.ReadLine();
                    
                    string[] values = line.Split(',');

                    PlayerData playerData = new PlayerData();
                    playerData.Set(values[0], Convert.ToInt32(values[1]));
                    playerDatas.Add(playerData);

                    
                    foreach (string list in lists)
                    {
                        
                    }
                   
                }

                sr.Close();
            }

            PlayerData tmp;
            for(int i = 0; i < playerDatas.Count();++i)
            {
                for(int j = i+1;j<playerDatas.Count();++j)
                {
                    if(playerDatas[i].GetCount() > playerDatas[j].GetCount())
                    {
                        tmp = playerDatas[i];
                        playerDatas[i] = playerDatas[j];
                        playerDatas[j] = tmp;
                    }
                }
            }


                return playerDatas;
        }

    }
}
