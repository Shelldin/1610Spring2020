using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from brackeys to tutorial
public class TrailMovement : MonoBehaviour
{
    public int speed = 235;

    void Update()
    {
      transform.Translate(Vector3.right*Time.deltaTime*speed);
      Destroy(this.gameObject, 1f);
    }
}
