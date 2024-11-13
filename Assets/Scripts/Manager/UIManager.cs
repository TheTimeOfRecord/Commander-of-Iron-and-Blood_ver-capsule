using System.Collections.Generic;
using Constants;
using UnityEngine;

public class UIManager : SingletoneBase<UIManager>
{
    private Dictionary<string, UIBase> _uiList = new Dictionary<string, UIBase>();

    public T GetUI<T>() where T : UIBase
    {
        var uiName = typeof(T).Name;
        
        if(_uiList.TryGetValue(uiName, out var value) && value != null)
            return value as T;
        else
            return CreateUI<T>();
    }

    private T CreateUI<T>() where T : UIBase
    {
        var uiName = typeof(T).Name;
        
        T uiRes = Resources.Load<T>($"{PathInfo.UIPath}{uiName}");
        var uiObj = Instantiate(uiRes);
        
        return uiObj;
    }

    public bool IsExistUI<T>() where T : UIBase
    {
        var uiName = typeof(T).Name;
        return _uiList.ContainsKey(uiName) && _uiList[uiName] != null;
    }

    public T OpenUI<T>() where T : UIBase
    {
        T ui = GetUI<T>();
        ui.Open();
        
        return ui;
    }
    
    public T CloseUI<T>() where T : UIBase
    {
        T ui = GetUI<T>();
        ui.Close();
        
        return ui;
    }

    public void Clear()
    {
        _uiList.Clear();    
    }
}
