using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacementUI : MonoBehaviour
{
    [SerializeField] private BuildingPlacementManager BuildingPlacementManager;

    [SerializeField] private SelectBuildingButton SelectBuildingButton;
    [SerializeField] private Transform ScrollRectContent;

    private void Start()
    {
        foreach (var BuildingData in BuildingPlacementManager.AllBuildings.Data)
        {
            SelectBuildingButton button = Instantiate(
                SelectBuildingButton, ScrollRectContent);
            button.Setup(BuildingData, BuildingPlacementManager);
        }
    }
}