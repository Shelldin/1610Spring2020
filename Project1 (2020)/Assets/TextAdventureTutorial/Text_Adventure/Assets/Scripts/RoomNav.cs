using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial
[RequireComponent(typeof(GameControllerScript))]
public class RoomNav : MonoBehaviour
{
  public RoomSO currentRoom;

  Dictionary<string, RoomSO> exitDictionary = new Dictionary<string, RoomSO>();
  
  private GameControllerScript gameController;

  private void Awake()
  {
    gameController = GetComponent<GameControllerScript>();
  }

  public void UnpackExits()
  {
    for (int i = 0; i < currentRoom.exits.Length; i++)
    {
      exitDictionary.Add(currentRoom.exits[i].keyString, currentRoom.exits[i].valueRoom);
      gameController.inRoomInteractions.Add(currentRoom.exits[i].exitDescription);
    }
  }

  public void AttemptToChangeRooms(string direction)
  {
    if (exitDictionary.ContainsKey(direction))
    {
      currentRoom = exitDictionary[direction];
      gameController.LogStringWithReturn("Ye embarketh to the " +direction);
      gameController.DisplayRoomText();
    }
    else
    {
      gameController.LogStringWithReturn("Ye cannot go " +direction);
    }
  }

  public void ClearExits()
  {
    exitDictionary.Clear();
  }
}
