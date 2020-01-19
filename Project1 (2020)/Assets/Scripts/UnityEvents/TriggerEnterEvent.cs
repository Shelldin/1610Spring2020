using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterEvent : MonoBehaviour
{
   public UnityEvent OnTriggerEnterEvent;

   private void OnTriggerEnter()
   {
      OnTriggerEnterEvent.Invoke();
   }
}
