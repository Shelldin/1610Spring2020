using System;
using UnityEngine;
[CreateAssetMenu]
public class GameArtData : ScriptableObject
{
    public Sprite sprite;
    public Color color = Color.red;
    public GameObject prefab;

    public void SetSprite(Sprite other)
    {
        sprite = other;
    }
}
