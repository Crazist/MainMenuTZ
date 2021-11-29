using UnityEngine;

public class Taxes : MonoBehaviour, IButton
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
            Debug.Log("TaxesOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("TaxesClose");
            IsActive = false;
        }

    }
}
