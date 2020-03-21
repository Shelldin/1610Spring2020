using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial
public abstract class ActionResponse : ScriptableObject
{
   public string requiredString;

   public abstract bool DoActionResponse(GameControllerScript controller);
}
