using UnityEngine;

///<summary>
/// 
///</summary>
public interface IInteractible
{

	#region Methods
	/// <summary>
	/// Called the first frame of interaction
	/// </summary>
	private void BeginInteract()
    {

    }

	/// <summary>
	/// Called every frame while in interaction
	/// </summary>
	private void Interact()
    {

    }

	/// <summary>
	/// Called when leaving interaction
	/// </summary>
	private void EndInteraction()
    {

    }
	#endregion


	#region Accessors
	bool isInteractionAllowed { get; set; }

	#endregion

}