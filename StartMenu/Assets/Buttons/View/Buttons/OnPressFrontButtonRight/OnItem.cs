using UnityEngine;

public class OnItem : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Items>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
