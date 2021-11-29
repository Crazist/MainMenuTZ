using UnityEngine;

public class OnGuard : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Guard>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
