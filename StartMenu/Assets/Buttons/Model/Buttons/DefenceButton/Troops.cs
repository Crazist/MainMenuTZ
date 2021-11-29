using UnityEngine;

public class Troops : MonoBehaviour, IButton
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
            Debug.Log("TroopsOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("TroopsClose");
            IsActive = false;
        }

    }
}
