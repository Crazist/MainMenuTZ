using UnityEngine;

public class OnMinistry : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Ministry>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
