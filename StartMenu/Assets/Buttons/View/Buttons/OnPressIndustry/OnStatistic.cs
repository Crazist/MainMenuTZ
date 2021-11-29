using UnityEngine;

public class OnStatistic : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Statistic>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
