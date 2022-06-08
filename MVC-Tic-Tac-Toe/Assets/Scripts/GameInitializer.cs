using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Viewers;

public class GameInitializer : MonoBehaviour
{
    [SerializeField] private GridController gridController;
    [SerializeField] private GridView gridView;


    private void Start()
    {
        gridView.CreateModelConnection(gridController.grid);
        gridController.PopulateGrid();
    }
}