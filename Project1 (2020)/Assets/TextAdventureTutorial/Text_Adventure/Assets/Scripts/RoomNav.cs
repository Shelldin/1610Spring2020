using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial
[RequireComponent(typeof(GameControllerScript))]
public class RoomNav : MonoBehaviour
{
  public RoomSO currentRoom;

  private GameControllerScript gameController;

  private void Awake()
  {
    gameController = GetComponent<GameControllerScript>();
  }

  public void UnpackExits()
  {
    for (int i = 0; i < currentRoom.exits.Length; i++)
    {
      gameController.inRoomInteractions.Add(currentRoom.exits[i].exitDescription);
    }
  }
}
