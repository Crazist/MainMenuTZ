using UnityEngine;

public class OnStorage : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Storage>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
