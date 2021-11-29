using UnityEngine;

public class OnEnvironment : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Environment>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
