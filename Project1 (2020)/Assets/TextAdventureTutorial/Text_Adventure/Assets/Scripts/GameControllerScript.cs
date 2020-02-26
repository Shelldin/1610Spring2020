using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial
[RequireComponent(typeof(RoomNav))]
public class GameControllerScript : MonoBehaviour
{
    [HideInInspector] public RoomNav roomNav;
    
    void Awake()
    {
        roomNav = GetComponent<RoomNav>();
    }

    public void DisplayRoomText()
    {
        string combinedText = roomNav.currentRoom.roomDescription + "\n";
    }

    void Update()
    {
        
    }
}
