using UnityEngine;

public class Foreign : MonoBehaviour, IButton
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
            Debug.Log("ForeignOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("ForeignClose");
            IsActive = false;
        }

    }
}
