using System;
using System.Collections;
using System.Collections.Generic;
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
}
