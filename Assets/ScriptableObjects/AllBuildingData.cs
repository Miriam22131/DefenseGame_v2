using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "AllBuildingsData",
    menuName = "Create Scriptable Objects/All Buildings Data")]
public class AllBuildingData : ScriptableObject
{
    internal IEnumerable<object> DataList;
    [SerializeField] private BuildingData[] _data;
    public BuildingData[] Data => _data;
   
}

public enum BuildingType
{
    None = 0,
    Decor = 1,
    Heart = 2,
    Defensive = 3,
    Passive = 4,
    ResourceProduction = 5,

}
