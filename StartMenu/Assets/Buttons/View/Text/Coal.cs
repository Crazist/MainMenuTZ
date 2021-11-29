using UnityEngine.UI;
using UnityEngine;


public class Coal : MonoBehaviour
{
    [SerializeField]
    private CoalData coalData;
    [SerializeField]
    private Text coalCount;

    private void Start()
    {
        coalCount.text = $"{coalData.StartCoalCount}";
    }

    private void CangeValue()
    {
        Debug.Log("Null"); // Метод для изменения количества coal извне;
    }
}
