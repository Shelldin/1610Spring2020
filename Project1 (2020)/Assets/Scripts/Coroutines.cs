using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    
    public float seconds = 1f;

    public int counter = 10;

    private IEnumerator coroutine;

    private WaitForSeconds wfsObj;

    private void Awake()
    {
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
            counter--;
        }
        endEvent.Invoke();
    }
}
