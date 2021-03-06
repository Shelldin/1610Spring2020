﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehavior : MonoBehaviour
{
    private Text textObj;
    //public IntDataInClass intData;

    void Start()
    {
        textObj = GetComponent<Text>();
    }

   // public void Update()
   // {
   //     textObj.text = "Score: " + intData.value.ToString();
   // }

    public void ChangeTextMessage(string message)
    {
        textObj.text = message;
    }

    public void ChangeText(IntData obj)
    {
        textObj.text = obj.value.ToString();
    }

}
