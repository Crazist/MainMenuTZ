using UnityEngine;

public class Ministry : MonoBehaviour, IButton
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
            Debug.Log("MinistryOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("MinistryClose");
            IsActive = false;
        }

    }
}
