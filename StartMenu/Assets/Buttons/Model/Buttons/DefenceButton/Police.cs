using UnityEngine;

public class Police : MonoBehaviour, IButton
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
            Debug.Log("PoliceOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("PoliceClose");
            IsActive = false;
        }

    }
}
