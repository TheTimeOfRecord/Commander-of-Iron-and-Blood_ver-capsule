using System;
using System.Collections.Generic;

public class DataManager : SingletoneBase<DataManager>
{
    
    private DataBase<ItemData> itemDb;
    public static DataBase<ItemData> ItemDb
    {
        get
        {
            if (Instance.itemDb == null)
            {
                var tmpList = new List<ItemData>()
                {
                    new ItemData(1001, "스파르타의 검", "스파르타의 개발자가 사용하는 검", "Sword_001"),
                    new ItemData(1002, "스파르타의 창", "스파르타의 개발자가 사용하는 창", "Spear_001"),
                    new ItemData(1003, "뿔피리", "튜터를 소환할 수 있습니다.","Item_001"),
                    new ItemData(1004, "시계", "마감시간이 다가옵니다...","Item_002"),
                    new ItemData(1005, "가방", "버그가 한가득 들어있는 가발이다","Item_003"),
                    new ItemData(1006, "디버깅 마스크", "디버그 악귀가 될 수 있습니다.","Item_004")
                };
                
                Instance.itemDb = new DataBase<ItemData>(tmpList);
            }
            
            return Instance.itemDb;
        }
    }

    private DataBase<ProductData> productDb;
    public static DataBase<ProductData> ProductDb
    {
        get
        {
            if (Instance.productDb == null)
            {
                var tmpList = new List<ProductData>()
                {
                    // 무기
                    new ProductData(2001, 1001, 3000),
                    new ProductData(2002, 1002, 3500),
                    
                    // 잡화도구
                    new ProductData(2003, 1003, 4000),
                    new ProductData(2004, 1004, 5000),
                    new ProductData(2005, 1005, 6000),
                    new ProductData(2006, 1006, 100000),
                };
                
                Instance.productDb = new DataBase<ProductData>(tmpList);
            }
            
            return Instance.productDb;
        }
    }
    
    private DataBase<ShopData> shopDb;
    public static DataBase<ShopData> ShopDb
    {
        get
        {
            if (Instance.shopDb == null)
            {
                var tmpList = new List<ShopData>()
                {
                    new ShopData(3001, "장비 상점",new List<int>()
                    {
                        2001,
                        2002
                    }),
                    
                    new ShopData(3002, "소모품 상점",new List<int>()
                    {
                        2003,
                        2004,
                        2005,
                        2006
                    }),
                };
                
                Instance.shopDb = new DataBase<ShopData>(tmpList);
            }
            
            return Instance.shopDb;
        }
    }
}
