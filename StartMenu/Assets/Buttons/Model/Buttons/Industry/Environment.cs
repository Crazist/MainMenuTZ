using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour, IButton
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
            Debug.Log("EnvironmentOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("EnvironmentClose");
            IsActive = false;
        }

    }
}
