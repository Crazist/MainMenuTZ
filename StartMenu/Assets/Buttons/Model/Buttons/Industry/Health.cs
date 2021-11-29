using UnityEngine;

public class Health : MonoBehaviour, IButton
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
            Debug.Log("HealthOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("HealthClose");
            IsActive = false;
        }

    }
}
