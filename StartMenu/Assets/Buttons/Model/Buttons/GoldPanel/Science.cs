using UnityEngine;

public class Science : MonoBehaviour, IButton
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
            Debug.Log("ScienceOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("ScienceClose");
            IsActive = false;
        }

    }
}
