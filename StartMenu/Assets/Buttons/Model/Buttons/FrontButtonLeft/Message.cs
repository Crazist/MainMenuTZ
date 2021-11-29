using UnityEngine;

public class Message : MonoBehaviour, IButton
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
            Debug.Log("MessageOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("MessageClose");
            IsActive = false;
        }

    }
}
