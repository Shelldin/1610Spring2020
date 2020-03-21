using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from uinitytutorial

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Use")]
public class Use : InputAction
{
    public override void RespondToInput(GameControllerScript controller, string[] separateInputWords)
    {
        controller.useableItems.UseItem(separateInputWords);
    }
}
