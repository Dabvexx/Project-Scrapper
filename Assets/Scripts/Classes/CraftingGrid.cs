using UnityEngine;
using System.Collections.Generic;
using System.Text;

///<summary>
///
///</summary>
[System.Serializable]
public class CraftingGrid
{
    public int gridLength;
    public int gridWidth;

    public List<bool> grid;

    //public List<bool> grid;
    public CraftingGrid(int _gridLength, int _gridHeight)
    {
        this.gridLength = _gridLength;
        this.gridWidth = _gridHeight;
        grid = new List<bool>();
        //grid = new List<bool>(_gridLength * _gridHeight);
        for (int i = 0; i < gridLength * gridWidth; i++)
        {
            grid.Add(false);
        }
    }

    // Return bool to tell if operation was successful.
    /// <summary>
    /// Function to check if the grid item can fit where the user tries to put it.
    /// If it can't fit, will return false, while returns true if it can.
    /// </summary>
    /// <param name="gridOffset">The tile where the player clicked</param>
    /// <param name="itemOffsets">The offsets of every tile to be covered by the item</param>
    /// <returns></returns>
    public bool ValidatePlacement(int initialOffset, GridItem gridItem)
    {
        // If all the tiles are valid, The grid item will flip the bits accordingly

        // Overall check to see if the item is bigger than the grid itself;
        if (gridItem.grid.Count > grid.Count)
        {
            Debug.Log($"GridItem Size: {gridItem.grid.Count}, Grid Size: {grid.Count}");
            // Invalid
            Debug.Log("Item is invalid: Too large for grid");
            return false;
        }

        // Check if item fits horizontally.
        if ((initialOffset % gridLength) + gridItem.gridLength > gridLength)
        {
            // Invalid
            Debug.Log("Item is invalid: Too large horizontally");
            return false;
        }

        // Check if item fits Vertically.
        if (Mathf.CeilToInt(initialOffset / gridLength) + gridItem.gridWidth > gridWidth)
        {
            // Invalid
            Debug.Log("Item is invalid: Too large vertically");
            return false;
        }

        Debug.Log("Item is valid");
        return true;
    }

    private bool ValidateCell()
    {
        // make sure the cell is not a 1 when its also a 1;
        return true;
    }

    public bool PlaceItem(int initalOffset, GridItem gridItem)
    {
        int rowCounter = 0;
        int counter = 0;

        if (!ValidatePlacement(initalOffset, gridItem))
        {
            return false;
        }

        for (int i = 0; i < gridItem.grid.Count; i++)
        {
            // Calculate the offset to when to witch to the next row
            //int rowCounter = (initalOffset + i) * Mathf.FloorToInt(i / gridItem.gridLength);
            int index = (rowCounter * gridLength) + counter + initalOffset;
            Debug.Log($"Counter: {counter}, Row: {rowCounter}, Index: {index}, gridSize: {grid.Count}");
            grid[index] = gridItem.grid[i];

            counter++;
            if ((i + 1) % gridItem.gridLength == 0)
            {
                rowCounter++;
                counter = 0;
            }
        }

        Debug.Log(PrintBits());
        return true;
    }

    public bool ConfirmCraft()
    {
        foreach (var cell in grid)
        {
            if (!cell)
            {
                return false;
            }
        }
        return true;
    }

    public string PrintBits()
    {
        StringBuilder sb = new StringBuilder(gridLength * gridWidth + gridWidth);
        int i = 1;

        foreach (var bit in grid)
        {
            if (bit)
            {
                sb.Append("1");
            }
            else
            {
                sb.Append("0");
            }

            if (i % gridLength == 0)
            {
                sb.AppendLine();
            }

            i++;
        }
        return sb.ToString();
    }
}