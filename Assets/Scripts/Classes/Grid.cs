using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEditor;

///<summary>
/// 
///</summary>
public class Grid
{
    [Min(1)] public int length;
    [HideInInspector] private int lengthChangeCheck;

    [Min(1)] public int width;
    [HideInInspector] private int widthChangeCheck;

    public int count 
    {
        get { return length * width; } 
    }

    [TableMatrix(RowHeight = 50, SquareCells = true, ResizableColumns = false, DrawElementMethod = "DrawCell")]
    public bool[,] grid;

    public Grid()
    {
        length = 1;
        width = 1;
        grid = new bool[1, 1];
    }

    public void OnValidate()
    {
        if (lengthChangeCheck != length)
        {
            grid = new bool[width, length];
            lengthChangeCheck = length;
        }
        else if (widthChangeCheck != width)
        {
            grid = new bool[width, length];
            widthChangeCheck = width;
        }
    }

    private static bool DrawCell(Rect rect, bool value)
    {
        if (Event.current.type == EventType.MouseDown && rect.Contains(Event.current.mousePosition))
        {
            value = !value;
            GUI.changed = true;
            Event.current.Use();
        }

        EditorGUI.DrawRect(
            rect,
            value ? Color.green : new Color(0, 0, 0, 0.5f)
            );

        return value;
    }

    private static void AdjustSize()
    {
        //var oldArr = 
    }
}