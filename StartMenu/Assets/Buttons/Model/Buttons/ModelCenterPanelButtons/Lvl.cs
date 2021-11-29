using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl : MonoBehaviour, IButton
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
            Debug.Log("LVLMenuOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("LVLMenuClose");
            IsActive = false;
        }

    }
}
