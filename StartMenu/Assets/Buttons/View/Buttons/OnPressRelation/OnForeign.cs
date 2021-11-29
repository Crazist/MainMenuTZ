using UnityEngine;

public class OnForeign : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Foreign>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
