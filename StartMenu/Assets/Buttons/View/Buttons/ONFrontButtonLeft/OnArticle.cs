using UnityEngine;

public class OnArticle : MonoBehaviour
{
    private IButton button;

    public void Start()
    {
        button = gameObject.AddComponent<Article>();
    }
    public void OnClick()
    {
        button.OnClick();
    }
}
