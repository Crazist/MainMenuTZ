using UnityEngine;

public class Religion : MonoBehaviour, IButton
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
            Debug.Log("ReligionOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("ReligionClose");
            IsActive = false;
        }

    }
}
