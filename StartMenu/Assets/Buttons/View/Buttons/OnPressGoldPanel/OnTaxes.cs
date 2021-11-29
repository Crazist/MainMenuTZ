using UnityEngine;

public class OnTaxes : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Taxes>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
