using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial
public class UsableItems : MonoBehaviour
{
    [HideInInspector] public List<string> nounsInRoom = new List<string>();
    
    List<string> nounsInInv = new List<string>();
    
    public string GetItemNotInInv(RoomSO currentRoom, int i)
    {
        InteractableItems ItemsInRoom = currentRoom.interactableItemsInRoom[i];

        if (!nounsInInv.Contains(ItemsInRoom.noun))
        {
            nounsInRoom.Add(ItemsInRoom.noun);
            return ItemsInRoom.itemDescription;
        }

        return null;
    }
}
