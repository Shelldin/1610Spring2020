using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// form unity tutorial

[CreateAssetMenu(menuName = "TextAdventure/Interactable Item")]
public class InteractableItems : ScriptableObject
{
    public string noun = "name";
    [TextArea]
    public string itemDescription = "description";

}
