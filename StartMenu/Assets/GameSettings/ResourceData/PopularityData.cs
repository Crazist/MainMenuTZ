using UnityEngine;

[CreateAssetMenu(fileName = "PopularityData", menuName = "ResorseData/PopularityData", order = 3)]
public class PopularityData : ScriptableObject
{
    [SerializeField]
    private float startPopularityCount;

    public float StartPopularityCount => startPopularityCount;
}
