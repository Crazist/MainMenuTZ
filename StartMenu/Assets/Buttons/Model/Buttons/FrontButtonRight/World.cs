using UnityEngine;

public class World : MonoBehaviour, IButton
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
            Debug.Log("WorldOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("WorldClose");
            IsActive = false;
        }

    }
}
