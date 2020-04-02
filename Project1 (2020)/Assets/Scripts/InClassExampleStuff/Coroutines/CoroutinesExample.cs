using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutinesExample : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;

    public IntData numberData;

    public int counter = 3;

    public float seconds = 1f;

    private WaitForSeconds wfsObj;

    

    private void Awake()
    {
        wfsObj =new WaitForSeconds(seconds);
    }

    IEnumerator Start()
    {
        startEvent.Invoke();
        
        while (counter>0)
        {
            numberData.value = counter;
            yield return wfsObj;
            repeatEvent.Invoke();
            counter--;
        }

        yield return wfsObj;
        endEvent.Invoke();
        
    }

    
}
