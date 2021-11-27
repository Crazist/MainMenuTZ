using UnityEngine.UI;
using UnityEngine;

public class Popularity : MonoBehaviour
{
    [SerializeField]
    private PopularityData popularityData;
    [SerializeField]
    private Text popularityCount;

    private void Start()
    {
        popularityCount.text = $"{popularityData.StartPopularityCount}";
    }

    private void CangeValue()
    {
        Debug.Log("Null"); // Метод для изменения количества stars извне;
    }
}
