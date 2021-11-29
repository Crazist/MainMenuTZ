using UnityEngine;

public class OnPressGold : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Trade>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
