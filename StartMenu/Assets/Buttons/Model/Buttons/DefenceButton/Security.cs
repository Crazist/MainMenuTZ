using UnityEngine;

public class Security : MonoBehaviour, IButton
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
            Debug.Log("SecurityOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("SecurityClose");
            IsActive = false;
        }

    }
}
