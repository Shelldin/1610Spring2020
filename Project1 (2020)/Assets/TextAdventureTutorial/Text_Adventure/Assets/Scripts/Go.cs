using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Go")]
public class Go : InputAction
{
    public override void RespondToInput(GameControllerScript controller, string[] separateInputWords)
    {
        controller.roomNav.AttemptToChangeRooms(separateInputWords[1]);
    }
}
