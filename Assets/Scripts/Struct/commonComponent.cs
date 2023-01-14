//using UnityEngine;

///<summary>
/// consists of things made of processed materials
/// the first common tier
/// (e.g. circuit boards, bolts, cable, plates, glass, motors
///</summary>
//[System.Serializable]
public struct commonComponent
{
	// Maybe advanced section has stuff like solar panels instead of engines

	enum materialTypes
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
	}

	materialTypes type;
	//public commonComponent()
	//{

	//}

}