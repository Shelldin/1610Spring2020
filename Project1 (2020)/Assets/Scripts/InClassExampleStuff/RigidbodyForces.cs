using System;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class RigidbodyForces : MonoBehaviour
{
   private Rigidbody rigidBodyObj;
   public float force = 100f;

   private Vector3 forceVector;

   private void Start()
   {
       rigidBodyObj = GetComponent<Rigidbody>();
   }

   private void OnCollisionEnter(Collision other)
   {
      forceVector.y = force;
      rigidBodyObj.AddForce(forceVector);
   }
}
