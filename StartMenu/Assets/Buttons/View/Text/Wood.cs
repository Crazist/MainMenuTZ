using UnityEngine.UI;
using UnityEngine;


public class Wood : MonoBehaviour
{
    [SerializeField]
    private WoodData woodData;
    [SerializeField]
    private Text woodCount;

    private void Start()
    {
        woodCount.text = $"{woodData.StartWoodCount}";
    }

    private void CangeValue()
    {
        Debug.Log("Null"); // Метод для изменения количества wood извне;
    }
}
