using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from brackeys tutorial
public class PlayerBehavior : MonoBehaviour
{
   [System.Serializable]
   public class PlayerStats
   {
      public int hitPoints = 100;
   }
   public PlayerStats playerStats = new PlayerStats();

   public float deathFallBoundary = -20f;

   private void Update()
   {
      if (transform.position.y <= deathFallBoundary)
      {
         DamagePlayer(999999999);
      }
   }

   public void DamagePlayer(int dmg)
   {
      playerStats.hitPoints -= dmg;
      if (playerStats.hitPoints <=0)
      {
         GameMasterBehavior.KillPlayer(this);
      }
   }
   
}
