using UnityEngine;

public class OnSport : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Sport>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
