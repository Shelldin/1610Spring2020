//from unity tutorial

using System;
using UnityEngine;

public class InvokeTutorial : MonoBehaviour
{
    public GameObject createdObj;
    public GameObject objCreator;

    private Vector3 position;

    private void Start()
    {
        position = objCreator.transform.position;
        Invoke("CreateObject", 3f);
    }

    private void CreateObject()
    {
        Instantiate(createdObj, position, Quaternion.identity);
    }
}
