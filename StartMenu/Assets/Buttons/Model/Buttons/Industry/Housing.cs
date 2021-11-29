using UnityEngine;

public class Housing : MonoBehaviour, IButton
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
            Debug.Log("HousingOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("HousingClose");
            IsActive = false;
        }

    }
}
