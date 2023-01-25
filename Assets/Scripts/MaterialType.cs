//using UnityEngine;

///<summary>
/// 
///</summary>
namespace Materials
{
	[System.Serializable]
	// Consists of ores and raw forms of materials
	public enum RawMaterial
	{
		copperOre,
		ironOre,
		coal,
		crudeOil,
		goldOre,
		sand,
		quartz,
		wood
	}

	enum ProcessedMaterial
	{
		Steel,
		silicoln,
		stainlessSteel,
		CopperIngot,
		IronIngot,
		//coal,
		refinedOil,
		goldIngot,
		plastic,
		rubber
	}

	enum CommonComponent
	{
		//electricMotor,
		//batteries,
		engine,
		fuel,
		copperWire,
		oilLubricant,
		steelBolt,
		circuitBoards,
		rubberTreads
		// various plates
	}

	public enum MaterialType
    {
		none,
		steel = 1,
		plastic = 2,
		copper = 3,

		ingot = 32,
		plate = 64,
    }
}
