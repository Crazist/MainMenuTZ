using UnityEngine;

public class OnCulture : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Culture>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
