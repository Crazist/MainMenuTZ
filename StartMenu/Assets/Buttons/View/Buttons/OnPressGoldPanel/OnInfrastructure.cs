using UnityEngine;

public class OnInfrastructure : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Infrastructure>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
