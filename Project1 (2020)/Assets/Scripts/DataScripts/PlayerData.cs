using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public UnityAction<GameObject> instanceAction;
    public UnityEvent onRunEvent;

    public FloatData health;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var playerSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        playerSprite.sprite = sprite;
        playerSprite.color = color;
        instanceAction(newPlayer);
    }

    public void Run()
    {
        onRunEvent.Invoke();
    }
}
