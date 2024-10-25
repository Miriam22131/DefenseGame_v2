using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuildingManager
{
    private Player _owner;
    private GameManager _gameManager;

    private List<PlacedBuildingBase> _ownedBuildings = new();

    private Action _tick;

    public PlayerBuildingManager(Player owner, GameManager gameManager)
    {
        _owner = owner;
        _gameManager = gameManager;
    }

    public void AddBuilding(PlacedBuildingBase placedBuilding)
    {
        _ownedBuildings.Add(placedBuilding);
        placedBuilding.SetManager(this, ref _tick, _owner);
        
        
        {
       
        }
     
    }

    public void OnUpdate()
    {
        _tick?.Invoke();
    }


    public void AddBuildingCellEffect(Vector3 position, int range, int unitHealthChange)
    {
     
     
        {
     
        }
    }

    public void RemoveBuildingCellEffect(Vector3 position, int range, int unitHealthChange)
    {

      
        {
      
        }
    }
}