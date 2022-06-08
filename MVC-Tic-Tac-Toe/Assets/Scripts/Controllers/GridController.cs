using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using Grid = Models.Grid;


public class GridController : MonoBehaviour
{
    [SerializeField] private int gridWidth;
    [SerializeField] private int gridHeight;

    public Grid grid { get; private set; }

    public void Awake()
    {
        grid = new Grid(gridWidth, gridHeight);
    }

    public void PopulateGrid()
    {
        for (int y = 0; y < gridHeight; y++)
        {
            for (int x = 0; x < gridWidth; x++)
            {
                grid.CreateCell(x, y);
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            grid.GridCells[1, 1].Symbol = 'X';
        if (Input.GetKeyDown(KeyCode.S))
            grid.GridCells[1, 1].Symbol = 'O';
        if (Input.GetKeyDown(KeyCode.D))
            grid.GridCells[1, 1].Symbol = ' ';
    }
}
