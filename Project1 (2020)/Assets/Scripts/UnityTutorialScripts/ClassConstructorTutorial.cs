//from unity tutorial
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassConstructorTutorial : MonoBehaviour
{
   public class Things
   {
      public int ammo1,
         ammo2,
         ammo3;

      public float durability;

      public Things(int am1, int am2, int am3)
      {
         ammo1 = am1;
         ammo2 = am2;
         ammo3 = am3;
      }
      
      //type "ctor" to automatically insert snippet.
      public Things(int am1, float dura)
      {
         ammo1 = am1;
         durability = dura;
      }
      
      //constructor
      public Things()
      {
         ammo1 = 5;
         ammo2 = 5;
         ammo3 = 5;
      }
   }
   //Notes: "()" indicate a constructor is being used.
   public Things myThings = new Things(10, 20, 30);
   
   public Things myOtherThings = new Things(40, 10.5f);
   
   
   //Notes: Name of a constructor is ALWAYS the name of the class.
   //Notes: Constructors NEVER have a return type (not even void).
   //Notes: A class can have multiple different constructors, but only one of them is called when the class gets initialized.
   
}
