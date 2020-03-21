using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial

[RequireComponent(typeof(GameControllerScript))]
public class UsableItems : MonoBehaviour
{
    public List<InteractableItems> usableItemList;
    
    public Dictionary<string, string> examineDictionary = new Dictionary<string, string>();
    public Dictionary<string, string> takeDictionary = new Dictionary<string, string>();

    [HideInInspector] public List<string> nounsInRoom = new List<string>();

    private Dictionary<string, ActionResponse> useDictionary = new Dictionary<string, ActionResponse>();

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

    public void AddActionResponsesToUseDictionary()
    {
        for (int i = 0; i < nounsInInv.Count; i++)
        {
            string noun = nounsInInv[i];

            InteractableItems interactableItemsInInv = GetInteractableItemFromUsableList(noun);
            if (interactableItemsInInv == null)
                continue;

            for (int j = 0; j < interactableItemsInInv.interactions.Length; j++)
            {
                Interaction interaction = interactableItemsInInv.interactions[j];

                if (interaction.actionResponse == null)
                    continue;

                if (!useDictionary.ContainsKey(noun))
                {
                    useDictionary.Add(noun, interaction.actionResponse);
                }
            }
        } 
    }

    InteractableItems GetInteractableItemFromUsableList(string noun)
    {
        for (int i = 0; i < usableItemList.Count; i++)
        {
            if (usableItemList[i].noun == noun)
            {
                return usableItemList[i];
            }
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
            AddActionResponsesToUseDictionary();
            nounsInRoom.Remove(noun);
            return takeDictionary;
        }

        else
        {
            controller.LogStringWithReturn("Ye cannot take" + noun);
            return null;
        }
    }

    public void UseItem(string[] separatedInputWords)
    {
        string nounToUse = separatedInputWords[1];

        if (nounsInInv.Contains(nounToUse))
        {
            if (useDictionary.ContainsKey(nounToUse))
            {
                bool actionResult = useDictionary[nounToUse].DoActionResponse(controller);
                if (!actionResult)
                {
                    controller.LogStringWithReturn("OAK: This isn't the time to use that!");
                }
            }
            else
            {
                controller.LogStringWithReturn("Thou cannotst deau that.");
            }
        }
        else
        {
            controller.LogStringWithReturn("Thou cannotst deau that. Quit making stuffeth up!");
        }
    }
}
