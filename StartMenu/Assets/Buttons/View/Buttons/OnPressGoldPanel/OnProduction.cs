using UnityEngine;

public class OnProduction : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Production>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
