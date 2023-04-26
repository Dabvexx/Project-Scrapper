using UnityEngine;
using UnityEditor;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

///<summary>
///
///</summary>
[ManageableData]
[CreateAssetMenu(fileName = "NewGridItem", menuName = "Grid Item")]
public class GridItem : SerializedScriptableObject
{
    [OdinSerialize] Grid grid = new Grid();

    private void OnValidate()
    {
        if (grid != null)
        {
            grid.OnValidate();
        }
    }
}