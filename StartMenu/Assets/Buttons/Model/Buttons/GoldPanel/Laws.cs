using UnityEngine;

public class Laws : MonoBehaviour, IButton
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
            Debug.Log("LawsOpen");
            IsActive = true;
        }
        else
        {
            Debug.Log("LawsClose");
            IsActive = false;
        }

    }
}
