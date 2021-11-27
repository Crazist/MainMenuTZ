using UnityEngine;

public class OnMenu : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Menu>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
