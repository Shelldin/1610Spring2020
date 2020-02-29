using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GameControllerScript))]
//from unity tutorial
public class TextInput : MonoBehaviour
{
    public InputField inputField;
    private GameControllerScript controller;

    private void Awake()
    {
        controller = GetComponent<GameControllerScript>();
        inputField.onEndEdit.AddListener(AcceptStringInput);
    }

    private void AcceptStringInput(string userInput)
  {
      userInput = userInput.ToLower();
      controller.LogStringWithReturn(userInput);
      InputComplete();
      
  }

    private void InputComplete()
    {
        controller.DisplayActionLogText();
        inputField.ActivateInputField();
        inputField.text = null;
    }
}
