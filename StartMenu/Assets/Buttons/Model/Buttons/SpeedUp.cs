using UnityEngine;

public class SpeedUp : MonoBehaviour, IButton
{
    private bool IsSpeedUp;

    private void Start()
    {
        IsSpeedUp = false;
    }
    public void OnClick()
    {
        if (!IsSpeedUp)
        {
            Debug.Log("SpeedUp");
            IsSpeedUp = true;
        }
        else
        {
            Debug.Log("SpeedDecrease");
            IsSpeedUp = false;
        }
       
    }
}
