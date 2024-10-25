using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    [FormerlySerializedAs("_playerCount")] [SerializeField] private int PlayerCount = 1;
    [FormerlySerializedAs("_placementManager")] [SerializeField] private BuildingPlacementManager PlacementManager;
    [FormerlySerializedAs("_myEvent")] [SerializeField] private UnityEvent MyEvent;
    [FormerlySerializedAs("_UIElements")] [SerializeField] private Canvas[] UIElements;

    // Determine the grid size
    [FormerlySerializedAs("_gridWidth")] [SerializeField] private int GridWidth = 10;
    [FormerlySerializedAs("_gridHeight")] [SerializeField] private int GridHeight = 10;
    [FormerlySerializedAs("_cellSize")] [SerializeField] private int CellSize = 10;
    [FormerlySerializedAs("_cellTickRate")] [SerializeField] private float CellTickRate;
 

    private SortedList<int, Player> _playerController = new();

    private delegate void DisableUI();
    private DisableUI _toggleDelegate;


    private void Update()
    {
        if (Input.GetButtonDown("ToggleUI"))
        {
            _toggleDelegate.Invoke();
        }

        foreach (var p in _playerController.Values)
        {
            p.BuildingManager.OnUpdate();
        }

      
    }

    private void ToggleAllUI()
    {
        foreach (var ui in UIElements)
        {
            ui.enabled = !ui.enabled;
        }
    }

    //testing
    public Player GetPlayer(int playerIndex)
    {
        Player pReturn;
        if (!_playerController.TryGetValue(playerIndex, out pReturn))
        {
            Debug.LogError($"Tried to get player {playerIndex} but player does not exist!");
        }
        return pReturn;
    }
}