using UnityEngine;

public class Buy : MonoBehaviour, IButton
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
            Debug.Log("MarcetOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("MarcetClose");
            IsActive = false;
        }

    }
}
