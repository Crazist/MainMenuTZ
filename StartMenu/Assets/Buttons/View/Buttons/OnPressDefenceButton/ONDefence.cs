using UnityEngine;

public class ONDefence : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Defence>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
