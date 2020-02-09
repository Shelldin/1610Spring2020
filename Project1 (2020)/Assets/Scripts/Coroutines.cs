using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    
    public FloatData floatDataObj;
    
    

    private IEnumerator coroutine;
    
    public float seconds = 1f;

    public float counter;

    

    private WaitForSeconds wfsObj;

    private void Awake()
    {
        if (floatDataObj == null)
        {
            counter = counter;
        }

        else
        {
            counter = floatDataObj.value; 
        }
        wfsObj = new WaitForSeconds(seconds);
    }

    
    public void CallCoroutine()
    {
        coroutine = RunCoroutine();
        StartCoroutine(coroutine);
    }
    
    public void EndCoroutine()
    {
        StopCoroutine(coroutine);
    }
    

    IEnumerator RunCoroutine()
    {
        startEvent.Invoke();
        while (counter > 0)
        {
            
            repeatEvent.Invoke();
            yield return wfsObj;

            if (floatDataObj == null)
            {
                counter -= 1f;
            }
        }
        endEvent.Invoke();
    }
}
