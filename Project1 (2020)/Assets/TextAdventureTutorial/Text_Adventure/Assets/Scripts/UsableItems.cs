using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial

[RequireComponent(typeof(GameControllerScript))]
public class UsableItems : MonoBehaviour
{
    public Dictionary<string, string> examineDictionary = new Dictionary<string, string>();
    public Dictionary<string, string> takeDictionary = new Dictionary<string, string>();



    
    [HideInInspector] public List<string> nounsInRoom = new List<string>();
    
    List<string> nounsInInv = new List<string>();

    private GameControllerScript controller;

    private void Awake()
    {
        controller = GetComponent<GameControllerScript>();
    }

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

    public void DisplayInventory()
    {
        controller.LogStringWithReturn("Ye taketh a gander in thy rucksack, ye beholdeth: ");

        for (int i = 0; i < nounsInInv.Count; i++)
        {
            controller.LogStringWithReturn(nounsInInv [i]);
        }
    }

    public void ClearCollections()
    {
        examineDictionary.Clear();
        takeDictionary.Clear();
        nounsInRoom.Clear();
    }

    public Dictionary<string, string> Take(string[] separatedInputWords)
    {
        string noun = separatedInputWords[1];
        if (nounsInRoom.Contains(noun))
        {
            nounsInInv.Add(noun);
            nounsInRoom.Remove(noun);
            return takeDictionary;
        }

        else
        {
            controller.LogStringWithReturn("Ye cannot take" + noun);
            return null;
        }
    }
}
