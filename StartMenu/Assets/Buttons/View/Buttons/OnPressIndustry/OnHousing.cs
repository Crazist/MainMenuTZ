using UnityEngine;

public class OnHousing : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Housing>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
