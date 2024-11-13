public class ProductData : DataModel
{
    public int itemId;
    public int price;
    
    // 
    public float discout; // 할인 비율
    public string description; // 할인 문구
    
    
    
    public ProductData(int id, int itemId, int price)
    {
        this.id = id;
        this.itemId = itemId;
        this.price = price;
    }
}
