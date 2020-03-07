using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from Unity Tutorial


public abstract class InputAction : ScriptableObject
{
    public string keyWord;

    public abstract void RespondToInput(GameControllerScript controller, string[] separateInputWords);
}
