using UnityEngine;

[CreateAssetMenu(fileName = "GoldData", menuName = "ResorseData/GoldData", order = 1)]
public class GoldData : ScriptableObject
{
    [SerializeField]
    private float startGoldCount;
    [SerializeField]
    private float startGoldIncome;

    public float StartGoldCount => startGoldCount;
    public float StartGoldIncome => startGoldIncome;
}
