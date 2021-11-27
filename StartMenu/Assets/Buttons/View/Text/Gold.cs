using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    [SerializeField]
    private GoldData goldData;
    [SerializeField]
    private Text goldCount;
    [SerializeField]
    private Text income;

    private void Start()
    {
        goldCount.text = $"{goldData.StartGoldCount}";
        income.text = $"+{goldData.StartGoldIncome}";
    }

    private void CangeValue()
    {
        Debug.Log("Null"); // Метод для изменения количества золота извне;
    }
}
