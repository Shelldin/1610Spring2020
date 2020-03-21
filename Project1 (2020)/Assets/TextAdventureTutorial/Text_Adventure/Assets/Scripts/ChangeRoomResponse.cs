using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from Unity Tutorial 

[CreateAssetMenu(menuName = "TextAdventure/ActionResponse/ChangeRoom")]
public class ChangeRoomResponse : ActionResponse
{
   public RoomSO roomToChangeTo;

   public override bool DoActionResponse(GameControllerScript controller)
   {
      if (controller.roomNav.currentRoom.roomName == requiredString)
      {
         controller.roomNav.currentRoom = roomToChangeTo;
         controller.DisplayRoomText();
         return true;
      }

      else
      {
         return false;
      }
   }
}
