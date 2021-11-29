using UnityEngine.UI;
using UnityEngine;

public class Iron : MonoBehaviour
{
    [SerializeField]
    private IronData ironData;
    [SerializeField]
    private Text ironCount;

    private void Start()
    {
        ironCount.text = $"{ironData.StartIronCount}";
    }

    private void CangeValue()
    {
        Debug.Log("Null"); // Метод для изменения количества iron извне;
    }
}
