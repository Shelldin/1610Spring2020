using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public KeyCode key1 = KeyCode.A,
        key2 = KeyCode.D;

    private float direction1 = 0, direction2 = 180;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, direction2, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, direction1, 0);

        }
    }

    public void FlipRotate(float value)
    {
        transform.Rotate(0,value,0); 
    }
}
