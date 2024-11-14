using System;
using Constants;
using UnityEngine;
using UnityEngine.UI;

// Tmp Main UI
public class UICastleWall : UIBase
{
    [SerializeField] private Button btnParty;
    [SerializeField] private Button btnCharacterShop;
    [SerializeField] private Button btnItemShop;

    private UIShop uiShop;
    
    private void Start()
    {
        btnParty.onClick.AddListener(() =>
        {
            // TODO : 던전 파티 구성 탭으로 이동
        });

        btnCharacterShop.onClick.AddListener(() =>
        {
            // TODO : 모집 공고(CharacterShop) 탭으로 이동
            OpenShop(ShopCode.WeaponShopCode);
        });
        
        btnItemShop.onClick.AddListener(() =>
        {
            // TODO : 아이템 상점 탭으로 이동
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
