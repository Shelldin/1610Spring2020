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

    public InputAction[] inputActions;
    
    [HideInInspector] public RoomNav roomNav;
    [HideInInspector] public List<string> inRoomInteractions = new List<string>();
    [HideInInspector] public UsableItems useableItems;

    List<string> actionLog = new List<string>();
    void Awake()
    {
        useableItems = GetComponent<UsableItems>();
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
        ClearCollectionsForNewRoom();
        
        UnpackRoom();

        string joinedInteractionDiscriptions = string.Join("\n", inRoomInteractions.ToArray());
        
        string combinedText = roomNav.currentRoom.roomDescription + "\n" + joinedInteractionDiscriptions;
        
        LogStringWithReturn(combinedText);
    }

    private void UnpackRoom()
    {
        roomNav.UnpackExits();
        PrepareItemsToTakeOrExamine(roomNav.currentRoom);
    }

    private void PrepareItemsToTakeOrExamine(RoomSO currentRoom)
    {
        for (int i = 0; i < currentRoom.interactableItemsInRoom.Length; i++)
        {
            string descriptionNotInInv = useableItems.GetItemNotInInv(currentRoom, i);
            if (descriptionNotInInv!= null)
            {
                inRoomInteractions.Add(descriptionNotInInv);
            }
        }
    }
    

    private void ClearCollectionsForNewRoom()
    {
        inRoomInteractions.Clear();
        roomNav.ClearExits();
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }

}
