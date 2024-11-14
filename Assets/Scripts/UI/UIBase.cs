using System;
using UnityEngine;

public class UIBase : MonoBehaviour 
{
    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}

