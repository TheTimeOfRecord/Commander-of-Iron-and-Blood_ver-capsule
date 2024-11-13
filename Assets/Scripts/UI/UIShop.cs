using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Constants;
using UnityEngine.UI;

public class UIShop : UIBase
{
    [SerializeField] private UIItemSlot slotBase;
    
    [SerializeField] private TMP_Text txtTitle;
    [SerializeField] private Transform contentParent;

    [SerializeField] private Button btnClose;
    
    private void Start()
    {
        btnClose.onClick.AddListener(Close);
    }

    public void SetShop(int shopId)
    {
        var shopData = DataManager.ShopDb.Get(shopId);
        
        txtTitle.text = shopData.shopName;
        
        foreach (var productId in shopData.productLsit)
        {
            var product = DataManager.ProductDb.Get(productId);
            
            UIItemSlot slot = Instantiate(slotBase, contentParent);
            
            slot.SetData(product);
            slot.SetClickListener((id) => { ShopManager.Instance.BuyItem(id); });
            
            slot.gameObject.SetActive(true);
        }
    }
}
