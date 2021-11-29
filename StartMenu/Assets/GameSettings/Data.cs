using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "GameData/Data", order = 1)]

public class Data : ScriptableObject
{
    [SerializeField]
    private int startDayCount;
    [SerializeField]
    private int startMonthCount;
    [SerializeField]
    private int startYearCount;

    public int StartDayCount => startDayCount;
    public int StartMonthCount => startMonthCount;
    public int StartYearCount => startYearCount;


}
