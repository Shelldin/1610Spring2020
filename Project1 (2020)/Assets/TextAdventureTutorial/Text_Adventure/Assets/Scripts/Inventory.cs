using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Inventory")]
public class Inventory : InputAction
{
    public override void RespondToInput(GameControllerScript controller, string[] separateInputWords)
    {
        controller.useableItems.DisplayInventory();
    }
}
