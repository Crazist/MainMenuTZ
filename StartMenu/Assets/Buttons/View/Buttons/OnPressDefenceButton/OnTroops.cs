using UnityEngine;

public class OnTroops : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Troops>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
