using UnityEngine;

public class Infrastructure : MonoBehaviour, IButton
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
            Debug.Log("InfrastructureOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("InfrastructureClose");
            IsActive = false;
        }

    }
}
