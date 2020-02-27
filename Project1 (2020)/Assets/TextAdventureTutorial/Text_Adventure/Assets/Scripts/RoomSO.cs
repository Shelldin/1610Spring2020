using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial
[CreateAssetMenu(menuName = "TextAdventure/Room")]
public class RoomSO : ScriptableObject
{
    [TextArea]
    public string roomDescription;

    public string roomName;

    public Exits[] exits;
}
