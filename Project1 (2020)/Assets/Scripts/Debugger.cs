using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Debugger : ScriptableObject
{
    
    public void OnDebug (string words)
    {
        Debug.Log(words);
    }
}
