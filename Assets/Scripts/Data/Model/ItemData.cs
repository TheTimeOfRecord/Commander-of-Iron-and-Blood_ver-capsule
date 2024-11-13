public class ItemData : DataModel
{
    public string itemName;
    public string itemDescription;
    public string spritePath;
    
    public ItemData(int id, string itemName, string itemDescription, string spritePath)
    {
        this.id = id;
        this.itemName = itemName;
        this.itemDescription = itemDescription;
        this.spritePath = spritePath;
    }
}
