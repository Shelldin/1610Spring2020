//from Unity Tutorial

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Light))]

public class DeltaTimeTutorial : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float timerCount = 5f;
    private void Update()
    {
        timerCount -= Time.deltaTime;
        if (timerCount <= 0f)
        {
            GetComponent<Light>().enabled = true;
        }

        transform.position += new Vector3(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f,0f);
    }
}
