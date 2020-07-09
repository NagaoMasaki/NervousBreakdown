public class PlayerData
{
    int count;
    string name;


    public void Set(string name,int count)
    {
        this.name = name;
        this.count = count;
    }

    public string GetName()
    {
        return this.name;
    }

    public int GetCount()
    {
        return this.count;
    }


}