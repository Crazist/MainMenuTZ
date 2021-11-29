using UnityEngine;

public class OnBuy : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Buy>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
