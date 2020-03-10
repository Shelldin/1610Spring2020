using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Examine")]
public class Examine : InputAction
{
    public override void RespondToInput(GameControllerScript controller, string[] separateInputWords)
    {
        controller.LogStringWithReturn(controller.TestVerbDictionaryWithNoun
            (controller.useableItems.examineDictionary, separateInputWords [0], separateInputWords[1]));
    }
}
