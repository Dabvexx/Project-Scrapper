using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Materials;

public class test : MonoBehaviour
{
    #region Variables

    // Variables.
    private RawMaterial resource1;

    [SerializeField] private GridItem item;
    private CraftingGrid grid = new CraftingGrid(11, 11);

    #endregion Variables

    #region Unity Methods

    private void Start()
    {
        grid.PlaceItem(4, item);
    }

    private void Update()
    {
    }

    #endregion Unity Methods

    #region Private Methods

    // Private Methods.

    #endregion Private Methods

    #region Public Methods

    // Public Methods.

    #endregion Public Methods
}