using UnityEngine;

[CreateAssetMenu(
    fileName = "AllBuildingsData",
    menuName = "Create Scriptable Objects/All Buildings Data")]
public class AllBuildingData : ScriptableObject
{
    [SerializeField] private BuildingData[] _data;
    public BuildingData[] Data => _data;
   
    [SerializeField] private int[] _maxHp;
    [SerializeField] private int _armor;
    [SerializeField] private GameObject _buildingGhostPrefab;
    [SerializeField] private GameObject _buildingPlacedPrefab;
    [SerializeField] private Sprite _buildingSprite;
    [SerializeField] private BuildingType _kindOfStructure;

    public int[] MaxHp => _maxHp;
    public int Armor => _armor;
    public GameObject BuildingGhostPrefab => _buildingGhostPrefab;
    public GameObject BuildingPlacedPrefab => _buildingPlacedPrefab;
    public Sprite BuildingSprite => _buildingSprite;
    public BuildingType KindOfStructure => _kindOfStructure;

    public bool CanLevelUp(int currentLevel)
    {
        // Ensure the level is within valid bounds
        if (currentLevel < 0 || currentLevel >= _maxHp.Length)
            return false;

        // If the current level is less than the max level, then it can level up
        return currentLevel < _maxHp.Length - 1;
    }
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
