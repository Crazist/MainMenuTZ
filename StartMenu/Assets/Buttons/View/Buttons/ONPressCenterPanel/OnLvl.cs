using UnityEngine;

public class OnLvl : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Lvl>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
