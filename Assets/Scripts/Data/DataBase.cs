using System.Collections.Generic;

public class DataBase<T> where T : DataModel
{
    public Dictionary<int, T> db = new Dictionary<int, T>();

    public DataBase(List<T> tmpItemList)
    {
        GenerateDbFromList(tmpItemList);
    }

    void GenerateDbFromList(List<T> itemList)
    {
        foreach (var itemData in itemList)
            db.Add(itemData.id, itemData);
    }
    
    public T Get(int id)
    {
        if(db.ContainsKey(id))
            return db[id];

        return null;
    }


}
