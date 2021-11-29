using UnityEngine;

public class OnReligion : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Religion>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
