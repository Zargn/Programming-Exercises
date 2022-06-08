using Models;
using Unity.Mathematics;
using UnityEngine;
using Grid = Models.Grid;

namespace Viewers
{
    public class GridView : MonoBehaviour
    {
        [SerializeField] private GameObject cellViewPrefab;
        private float widthOffset;
        private float heightOffset;


        public void CreateModelConnection(Grid grid)
        {
            grid.CellAdded += CreateCellView;
            GetGridPositions();
        }

        private void CreateCellView(Cell cell, int x, int y)
        {
            var cellView = Instantiate(cellViewPrefab, new Vector3(x * 100 + widthOffset, y * 100 + heightOffset, 0), quaternion.identity, transform);
            cellView.GetComponent<CellView>().CreateModelConnection(cell);
        }

        private void GetGridPositions()
        {
            var rectT = GetComponent<RectTransform>();
            widthOffset = rectT.rect.size.x / 2 - 100;
            heightOffset = rectT.rect.size.y / 2 - 100;
        }
    }
}