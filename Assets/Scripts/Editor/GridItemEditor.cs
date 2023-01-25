using UnityEngine;
using UnityEditor;

///<summary>
/// 
///</summary>
[CustomEditor(typeof(GridItem))]
public class GridItemEditor : Editor
{
	GridItem gridItem;

	private void OnEnable()
	{
	}

	public override void OnInspectorGUI()
	{
		gridItem = (GridItem)target;

		base.OnInspectorGUI();
		if(GUILayout.Button("Regenerate Grid"))
        {
			gridItem.RegenerateGrid();
        }
	}

}