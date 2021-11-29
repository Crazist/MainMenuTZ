using UnityEngine;

[CreateAssetMenu(fileName = "IronData", menuName = "ResorseData/IronData", order = 6)]
public class IronData : ScriptableObject
{
    [SerializeField]
    private float startIronCount;

    public float StartIronCount => startIronCount;
}
