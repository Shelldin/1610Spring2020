﻿
using UnityEngine;
[CreateAssetMenu]
public class StringData : ScriptableObject
{
    public string value;

    public void ChangeValue(string input)
    {
        value = input;
    }
}
