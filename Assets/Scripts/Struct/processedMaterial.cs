//using UnityEngine;

///<summary>
/// Consists of refined versions of meterials (such as ingots, bars, excetra)
///</summary>
//[System.Serializable]
public struct processedMaterial
{
	// Maybe make an alloy material struct for stuff like steel, maybe eeven further for things like stainless steel
	// dont do all at once due to scop creep
	enum materialTypes
	{
		Steel,
		stainlessSteel,
		Copper,
		//Iron,
		//coal,
		refinedOil,
		goldIngot,
		plastic,
		rubber
	}

	materialTypes type;
	//public processedMaterial()
	//{

	//}

}