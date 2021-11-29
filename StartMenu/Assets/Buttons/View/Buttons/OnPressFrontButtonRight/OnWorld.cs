using UnityEngine;

public class OnWorld : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<World>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
