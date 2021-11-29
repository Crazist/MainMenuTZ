using UnityEngine;

public class Population : MonoBehaviour, IButton
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
            Debug.Log("PopulationOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("PopulationClose");
            IsActive = false;
        }

    }
}
