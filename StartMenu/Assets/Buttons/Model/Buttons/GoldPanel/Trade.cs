using UnityEngine;

public class Trade : MonoBehaviour, IButton
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
            Debug.Log("TradeOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("TradeClose");
            IsActive = false;
        }

    }
}
