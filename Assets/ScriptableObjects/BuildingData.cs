using UnityEngine;

[CreateAssetMenu(
    fileName = "BuildingData",
    menuName = "Create Scriptable Objects/Building Data")]
public class BuildingData : ScriptableObject
{
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
        if (currentLevel <= 0)
            return false;

        bool isMaxLevel = currentLevel < _maxHp.Length;
        return !isMaxLevel;
    }
}

