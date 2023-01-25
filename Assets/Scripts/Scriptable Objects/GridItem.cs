using UnityEngine;
using System.Collections.Generic;
using Sirenix.Serialization;
using System;
using Sirenix.OdinInspector;

///<summary>
///
///</summary>
[ManageableData]
[CreateAssetMenu(fileName = "NewGridItem", menuName = "Grid Item")]
public class GridItem : SerializedScriptableObject
{
    // Make an editor script to set the length and height based off a text area, where a \n makes the row length.
    public int gridLength;

    public int gridWidth;

    [Multiline(10)]
    public string bitPattern = "";

    public List<bool> grid;

    public void RegenerateGrid()
    {
        char[] bits = bitPattern.ToCharArray();

        grid = new List<bool>();

        int newBit;
        int lengthCounter = 0;
        int highestLength = 0;
        int widthCounter = 0;
        // Find a way to find the longest length of a line then to construct the grid by adding extra 0s if needed
        foreach (var bit in bits)
        {
            Debug.Log(bit);
            if (!int.TryParse(bit.ToString(), out newBit))
            {
                if (lengthCounter >= highestLength)
                {
                }

                widthCounter++;
                continue;
            }

            lengthCounter++;
            grid.Add(newBit == 1 ? true : false);
        }

        //gridLength = highestLength;
        //gridWidth = widthCounter;
    }
}