using UnityEngine;

public class OnHealth : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Health>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
