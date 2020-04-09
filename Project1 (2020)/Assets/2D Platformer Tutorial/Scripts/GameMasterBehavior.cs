using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterBehavior : MonoBehaviour
{
    public static void KillPlayer(PlayerBehavior player)
    {
        Destroy(player.gameObject);
    }
}
