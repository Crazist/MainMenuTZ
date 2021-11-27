using UnityEngine;

public class OnStart : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Start>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
