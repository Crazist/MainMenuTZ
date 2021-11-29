using UnityEngine;

public class Article : MonoBehaviour, IButton
{
    private bool IsActive;

    private void Start()
    {
        IsActive = false;
    }
    public void OnClick()
    {
        if (!IsActive)
        {
            Debug.Log("ArticleOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("ArticleClose");
            IsActive = false;
        }

    }
}
