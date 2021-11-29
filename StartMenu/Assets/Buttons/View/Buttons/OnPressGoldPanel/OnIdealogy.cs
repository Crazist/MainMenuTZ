using UnityEngine;

public class OnIdealogy : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Idealogy>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
