using UnityEngine;

public class OnMessage : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Message>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
