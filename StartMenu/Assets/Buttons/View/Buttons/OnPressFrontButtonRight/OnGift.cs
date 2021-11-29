using UnityEngine;

public class OnGift : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Gift>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
