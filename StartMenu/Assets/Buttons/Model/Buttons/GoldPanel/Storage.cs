using UnityEngine;

public class Storage : MonoBehaviour, IButton
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
            Debug.Log("StorageOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("StorageClose");
            IsActive = false;
        }

    }
}
