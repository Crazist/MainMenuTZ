using UnityEngine;

public class OnPolice : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Police>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
