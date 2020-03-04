using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
   public Vector3 value;

   public void ChangePosition(Transform transformObj)
   {
      transformObj.position = value;
   }

   public void ChangeVector3Data(Vector3Data vector3DataObj)
   {
      vector3DataObj.value = value;
   }

   public void ChangeValueFromTransform(Transform transformObj)
   {
      value = transformObj.position;
   }

   public void UpdateX(float amount)
   {
      value.x += amount;
   }

   public void UpdateY(float amount)
   {
      value.y += amount;
   }

   public void UpdateZ(float amount)
   {
      value.z += amount;
   }
}
