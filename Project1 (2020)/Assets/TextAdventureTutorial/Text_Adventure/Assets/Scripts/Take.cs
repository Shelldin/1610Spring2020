using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Take")]
public class Take : InputAction
{
    public override void RespondToInput(GameControllerScript controller, string[] separateInputWords)
    {
        Dictionary<string, string> takeDictionary = controller.useableItems.Take(separateInputWords);

        if (takeDictionary != null)
        {
          controller.LogStringWithReturn(controller.TestVerbDictionaryWithNoun(takeDictionary, separateInputWords[0],
              separateInputWords[1]));  
        }
    }
    
}
