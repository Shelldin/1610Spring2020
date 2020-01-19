using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterEvent : MonoBehaviour
{
   public UnityEvent onTriggerEnterEvent;

   private void OnTriggerEnter()
   {
      onTriggerEnterEvent.Invoke();
   }
}
