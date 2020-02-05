//from Brackeys Tutorial

using System;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public StateManager stateManager;
    private void OnTriggerEnter ()
    {
        stateManager.CompleteLevel();
    }
}
