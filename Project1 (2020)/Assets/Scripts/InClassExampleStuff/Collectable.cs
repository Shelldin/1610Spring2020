using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "InClassStuff/Collectable")]
public class Collectable : ScriptableObject
{
    public int powerLevel = 10;
    public Color collColor = Color.red;
    public Sprite collectableColor;

}