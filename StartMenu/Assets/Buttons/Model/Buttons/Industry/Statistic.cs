using UnityEngine;

public class Statistic : MonoBehaviour, IButton
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
            Debug.Log("StatisticOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("StatisticClose");
            IsActive = false;
        }

    }
}
