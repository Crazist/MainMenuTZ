using UnityEngine;

[CreateAssetMenu(fileName = "StarsData", menuName = "ResorseData/StarsData", order = 4)]
public class StarsData : ScriptableObject
{
    [SerializeField]
    private float startStarsCount;

    public float StartStarsCount => startStarsCount;
}
