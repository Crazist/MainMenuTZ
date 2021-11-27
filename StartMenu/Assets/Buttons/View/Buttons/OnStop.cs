using UnityEngine;

public class OnStop : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Stop>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
