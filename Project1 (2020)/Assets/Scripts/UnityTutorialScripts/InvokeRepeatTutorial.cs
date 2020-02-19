using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeatTutorial : MonoBehaviour
{
    public GameObject spawner;
    public GameObject spawnedObj;
    public int spawnCount = 5;
    public float seconds = 3f, spawnRate = 2f;

    private Vector3 position;

    private void Start()
    {
        position = spawner.transform.position;
        InvokeRepeating("Spawn", seconds, spawnRate);
    }

    private void Update()
    {
        if (spawnCount <= 0)
        {
            CancelInvoke("Spawn");
        }
    }

    private void Spawn()
    {
        Instantiate(spawnedObj, position, Quaternion.identity);
        spawnCount--;
    }
}
