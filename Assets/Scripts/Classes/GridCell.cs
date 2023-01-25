//using UnityEngine;
using Materials;
using Sirenix.OdinInspector;

///<summary>
/// 
///</summary>
[System.Serializable]
public class GridCell
{
	public bool hasItem;

	[ShowIf("hasItem")]
	public MaterialType material;
	public GridCell(bool _hasItem)
	{
		this.hasItem = _hasItem;
	}

}