using UnityEngine;

public class OnExperience : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Experience>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
