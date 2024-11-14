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
            // TODO : ���� ��Ƽ ���� ������ �̵�
        });

        btnCharacterShop.onClick.AddListener(() =>
        {
            // TODO : ���� ����(CharacterShop) ������ �̵�
            OpenShop(ShopCode.WeaponShopCode);
        });
        
        btnItemShop.onClick.AddListener(() =>
        {
            // TODO : ������ ���� ������ �̵�
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
