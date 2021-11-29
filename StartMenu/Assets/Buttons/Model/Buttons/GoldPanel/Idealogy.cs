using UnityEngine;

public class Idealogy : MonoBehaviour, IButton
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
            Debug.Log("IdealogyOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("IdealogyClose");
            IsActive = false;
        }

    }
}
