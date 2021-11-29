using UnityEngine;

public class Experience : MonoBehaviour, IButton
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
            Debug.Log("ExperienceOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("ExperienceClose");
            IsActive = false;
        }

    }
}
