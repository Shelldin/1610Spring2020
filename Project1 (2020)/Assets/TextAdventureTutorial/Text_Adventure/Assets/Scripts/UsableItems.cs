using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial
public class UsableItems : MonoBehaviour
{
    public Dictionary<string, string> examineDictionary = new Dictionary<string, string>();
    
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

    public void ClearCollections()
    {
        examineDictionary.Clear();
        nounsInRoom.Clear();
    }
}
