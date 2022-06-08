using System;
using Models;
using TMPro;
using UnityEngine;

namespace Viewers
{
    public class CellView : MonoBehaviour
    {
        [SerializeField] private TMP_Text symbol;
        
        public void CreateModelConnection(Cell cell)
        {
            cell.IconChanged += ChangeSymbol;
        }

        private void ChangeSymbol(char symbol)
        {
            this.symbol.text = symbol.ToString();
        }
    }
}