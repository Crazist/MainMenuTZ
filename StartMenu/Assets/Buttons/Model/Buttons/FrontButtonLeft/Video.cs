using UnityEngine;

public class Video : MonoBehaviour, IButton
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
            Debug.Log("VideoOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("VideoClose");
            IsActive = false;
        }

    }
}
