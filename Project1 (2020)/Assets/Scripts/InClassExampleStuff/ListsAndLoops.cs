using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "InClassStuff/ListsAndLoops")]
public class ListsAndLoops : ScriptableObject
{
    public List<string> stringList;
    public string singleString;

    public void SortList()
    {
        stringList.Sort();
    }

    public void AddToList(string stringObj)
    {
        stringList.Add(stringObj);
    }

    public void RemoveFromList(string stringObj)
    {
        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i] == stringObj)
            {
                stringList.Remove(stringObj);
            }
        }
    }

    public void CheckLists()
    {
        foreach (var obj in stringList)
        {
            if (obj.Contains(singleString))
            {
                Debug.Log(obj);
            }
        }
    }
}

