using UnityEngine;

public class OnSciens : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Science>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
