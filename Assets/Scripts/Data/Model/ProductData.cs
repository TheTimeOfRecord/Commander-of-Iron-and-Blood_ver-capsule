public class ProductData : DataModel
{
    public int itemId;
    public int price;
    
    // 
    public float discout; // ���� ����
    public string description; // ���� ����
    
    
    
    public ProductData(int id, int itemId, int price)
    {
        this.id = id;
        this.itemId = itemId;
        this.price = price;
    }
}
