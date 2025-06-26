using System;
using UnityEngine;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField] private GameObject mouseIndicator, cellIndicator;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private Grid grid;
    [SerializeField] private ObjectDatabaseSO database;
    [SerializeField] private GameObject gridVisualization;

    private void Start()
    {

    }

    public void StopPlacement()
    {

    }

    public void StartPlacement(int objectIndex)
    {

    }

    private void PlaceObject()
    {

    }

    private void Update()
    {
        Vector3 mouseWorldPosition = inputManager.GetSelectedCell();
        Vector3Int cellPosition = grid.WorldToCell(mouseWorldPosition);
        Vector3 snappedPosition = grid.GetCellCenterWorld(cellPosition);
        mouseIndicator.transform.position = new Vector3 (mouseWorldPosition.x,0.56f,mouseWorldPosition.z);
        cellIndicator.transform.position = snappedPosition;
    }
}
