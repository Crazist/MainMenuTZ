using UnityEngine;

public class OnPopulation : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Population>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
