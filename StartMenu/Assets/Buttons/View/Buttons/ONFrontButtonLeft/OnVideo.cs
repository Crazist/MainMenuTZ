using UnityEngine;

public class OnVideo : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Video>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
