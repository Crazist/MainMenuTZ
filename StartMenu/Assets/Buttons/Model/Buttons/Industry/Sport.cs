using UnityEngine;

public class Sport : MonoBehaviour, IButton
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
            Debug.Log("SportOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("SportClose");
            IsActive = false;
        }

    }
}
