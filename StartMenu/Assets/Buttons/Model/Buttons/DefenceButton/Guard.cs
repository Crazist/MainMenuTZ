using UnityEngine;

public class Guard : MonoBehaviour, IButton
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
            Debug.Log("GuardOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("GuardClose");
            IsActive = false;
        }

    }
}
