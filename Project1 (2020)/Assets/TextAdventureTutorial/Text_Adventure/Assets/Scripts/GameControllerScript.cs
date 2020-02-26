using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//from unity tutorial
[RequireComponent(typeof(RoomNav))]
public class GameControllerScript : MonoBehaviour
{
    public Text displayText;
    
    [HideInInspector] public RoomNav roomNav;
    
    List<string> actionLog = new List<string>();
    void Awake()
    {
        roomNav = GetComponent<RoomNav>();
    }

    private void Start()
    {
        DisplayRoomText();
        DisplayActionLogText();
    }

    public void DisplayActionLogText()
    {
        string LogAsText = string.Join("\n", actionLog.ToArray());

        displayText.text = LogAsText;
    }

    public void DisplayRoomText()
    {
        string combinedText = roomNav.currentRoom.roomDescription + "\n";
        
        LogStringWithReturn(combinedText);
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }

}
