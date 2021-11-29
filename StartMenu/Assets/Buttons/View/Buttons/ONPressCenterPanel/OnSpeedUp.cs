using UnityEngine;

public class OnSpeedUp : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<SpeedUp>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
