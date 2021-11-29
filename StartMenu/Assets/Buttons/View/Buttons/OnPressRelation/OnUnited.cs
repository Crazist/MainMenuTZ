using UnityEngine;

public class OnUnited : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<United>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
