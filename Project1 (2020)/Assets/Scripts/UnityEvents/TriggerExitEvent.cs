using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerExitEvent : MonoBehaviour
{
   public UnityEvent exitEvent;

   private void OnTriggerExit()
   {
      exitEvent.Invoke();
   }
}
