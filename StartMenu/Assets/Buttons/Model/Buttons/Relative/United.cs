using UnityEngine;

public class United : MonoBehaviour, IButton
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
            Debug.Log("UnitedOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("UnitedClose");
            IsActive = false;
        }

    }
}
