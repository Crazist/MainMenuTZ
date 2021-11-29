using UnityEngine;

public class OnCommand : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Command>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
