using UnityEngine;

[CreateAssetMenu(fileName = "WoodData", menuName = "ResorseData/WoodData", order = 5)]
public class WoodData : ScriptableObject
{
    [SerializeField]
    private float startWoodCount;

    public float StartWoodCount => startWoodCount;
}
