using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//from unity tutorial
public class Compass : MonoBehaviour
{
   enum CardinalDirection {N, E, S, W};

   private void Start()
   {
      CardinalDirection direction;

      direction = CardinalDirection.N;
   }

   CardinalDirection FlipDirection(CardinalDirection dir)
   {
      if (dir == CardinalDirection.N)
         dir = CardinalDirection.S;
      else if (dir == CardinalDirection.S)
         dir = CardinalDirection.N;
      else if (dir == CardinalDirection.E)
         dir = CardinalDirection.W;
      else if (dir == CardinalDirection.W)
         dir = CardinalDirection.E;

      return dir;
   }
}
