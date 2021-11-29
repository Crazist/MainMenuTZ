using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour, IButton
{
    private bool IsActive;

    private void Start()
    {
        IsActive = false;
    }
    public void OnClick()
    {
        if (!IsActive)
        {
            Debug.Log("MenuOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("MenuClose");
            IsActive = false;
        }

    }
}
