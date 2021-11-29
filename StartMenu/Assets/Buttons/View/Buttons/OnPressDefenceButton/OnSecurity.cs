using UnityEngine;

public class OnSecurity : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Security>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
