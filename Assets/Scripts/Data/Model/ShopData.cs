using System.Collections.Generic;

public class ShopData : DataModel
{
    public string shopName;
    public List<int> productLsit;
    
    public ShopData(int id, string shopName, List<int> productLsit)
    {
        this.id = id;
        this.shopName = shopName;
        this.productLsit = productLsit;
    }
}
