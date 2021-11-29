using UnityEngine;

[CreateAssetMenu(fileName = "CoalData", menuName = "ResorseData/CoalData", order = 7)]
public class CoalData : ScriptableObject
{
    [SerializeField]
    private float startCoalCount;

    public float StartCoalCount => startCoalCount;
}
