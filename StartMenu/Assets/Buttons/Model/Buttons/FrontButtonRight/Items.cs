using UnityEngine;

public class Items : MonoBehaviour, IButton
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
            Debug.Log("ItemsOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("ItemsClose");
            IsActive = false;
        }

    }
}
