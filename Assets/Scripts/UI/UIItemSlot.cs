using System;
using Constants;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIItemSlot : MonoBehaviour
{
    [SerializeField] private Image imgItem;
    [SerializeField] private TMP_Text txtName;
    [SerializeField] private TMP_Text txtDescription;
    [SerializeField] private TMP_Text txtPrice;

    [SerializeField] private Button btnBuy;

    private ProductData product;
    private ItemData item;
    
    private Action<int> onClickAction;
    
    public void SetData(ProductData product)
    {
        this.product = product;
        item = DataManager.ItemDb.Get(product.itemId);
        
        txtName.text = item.itemName;
        txtDescription.text = item.itemDescription;
        txtPrice.text = $"{product.price} G";

        var sprite = Resources.Load<Sprite>($"{PathInfo.SpritePath}{item.spritePath}");
        imgItem.sprite = sprite;
        
        btnBuy.onClick.AddListener(Click);
    }
    
    
    public void SetClickListener(Action<int> action)
    {
        onClickAction = action;
    }

    private void Click()
    {
        onClickAction?.Invoke(product.id);
    }
}
