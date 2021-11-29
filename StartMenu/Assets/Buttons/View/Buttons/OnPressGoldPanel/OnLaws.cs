using UnityEngine;

public class OnLaws : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Laws>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
