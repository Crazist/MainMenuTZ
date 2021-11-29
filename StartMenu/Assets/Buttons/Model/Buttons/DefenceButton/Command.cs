using UnityEngine;

public class Command : MonoBehaviour, IButton
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
            Debug.Log("CommandOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("CommandClose");
            IsActive = false;
        }

    }
}

