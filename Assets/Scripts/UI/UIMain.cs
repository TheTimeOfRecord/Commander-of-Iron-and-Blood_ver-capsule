using System;
using Constants;
using UnityEngine;
using UnityEngine.UI;

public class UIMain : UIBase
{
    [SerializeField] private Button btnWeaponShop;
    [SerializeField] private Button btnConsumableShop;

    private UIShop uiShop;
    
    private void Start()
    {
        btnWeaponShop.onClick.AddListener(() =>
        {
            OpenShop(ShopCode.WeaponShopCode);
        });
        
        btnConsumableShop.onClick.AddListener(() =>
        {
            OpenShop(ShopCode.ConsumableShopCode);
        });
    }

    private void OpenShop(int shopCode)
    {
        if (uiShop == null)
            uiShop = UIManager.Instance.GetUI<UIShop>();
        
        uiShop.Open();
        uiShop.SetShop(shopCode);
    }
}
