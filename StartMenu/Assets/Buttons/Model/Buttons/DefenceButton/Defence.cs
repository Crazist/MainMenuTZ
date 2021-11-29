using UnityEngine;

public class Defence : MonoBehaviour, IButton
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
            Debug.Log("DefenceOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("DefenceClose");
            IsActive = false;
        }

    }
}
