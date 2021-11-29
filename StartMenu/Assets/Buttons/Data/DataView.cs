using UnityEngine.UI;
using UnityEngine;
using System;
using System.Collections;

public class DataView : MonoBehaviour
{
    [SerializeField]
    private Data data;
    [SerializeField]
    private Text curData;

    private int day;
    private int month;
    private int year;

    private DateTime gameDate;

    private const int timeToWait = 5, addDays = 1;
    private void Start()
    {
        day = data.StartDayCount;
        month = data.StartMonthCount;
        year = data.StartYearCount;
        
        gameDate = new DateTime(year, month, day);
       
        StartCoroutine(GameDateLoop());
    }
    private IEnumerator GameDateLoop()
    {
       gameDate = gameDate.AddDays(addDays);
       curData.text = gameDate.ToString("MM.dd.yyyy");
       yield return new WaitForSeconds(timeToWait);
       StartCoroutine(GameDateLoop());
    }
}
