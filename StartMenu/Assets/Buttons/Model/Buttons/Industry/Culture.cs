using UnityEngine;

public class Culture : MonoBehaviour, IButton
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
            Debug.Log("CultureOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("CultureClose");
            IsActive = false;
        }

    }
}
