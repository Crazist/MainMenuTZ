using UnityEngine;

public class Production : MonoBehaviour, IButton
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
            Debug.Log("ProductionOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("ProductionClose");
            IsActive = false;
        }

    }
}
