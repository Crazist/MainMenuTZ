using UnityEngine;

[CreateAssetMenu(fileName = "DiomandsData", menuName = "ResorseData/DiomandsData", order = 2)]

public class DiomandsData : ScriptableObject
{
    [SerializeField]
    private float startDiomandsCount;
   
    public float StartDiomandsCount => startDiomandsCount;
}
