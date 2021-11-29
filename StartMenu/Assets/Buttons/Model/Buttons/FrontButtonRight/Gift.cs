using UnityEngine;

public class Gift : MonoBehaviour, IButton
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
            Debug.Log("GiftOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("GiftClose");
            IsActive = false;
        }

    }
}
