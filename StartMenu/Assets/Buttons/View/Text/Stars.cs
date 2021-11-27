using UnityEngine.UI;
using UnityEngine;

public class Stars : MonoBehaviour
{
    [SerializeField]
    private StarsData starsData;
    [SerializeField]
    private Text starsCount;

    private void Start()
    {
        starsCount.text = $"{starsData.StartStarsCount}";
    }

    private void CangeValue()
    {
        Debug.Log("Null"); // Метод для изменения количества stars извне;
    }
}
