using UnityEngine.UI;
using UnityEngine;

public class Diomands : MonoBehaviour
{
    [SerializeField]
    private DiomandsData diomandsData;
    [SerializeField]
    private Text diomandsCount;
   
    private void Start()
    {
        diomandsCount.text = $"{diomandsData.StartDiomandsCount}";
    }

    private void CangeValue()
    {
        Debug.Log("Null"); // Метод для изменения количества золота извне;
    }
}
