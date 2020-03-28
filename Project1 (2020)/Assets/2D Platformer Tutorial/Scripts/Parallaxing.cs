using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from Brackeys Tutorial
public class Parallaxing : MonoBehaviour
{
    public Transform[] scenery; //array of bg and fg transforms
    private float[] parallaxScaleing; // proportion the bg moves by
    public float parallaxSmoothing =1f; //must be above 0

    private Transform camera; //reference
    private Vector3 previousCameraPos; //pos of cam in previous frame

    private void Awake() //called before start. good for references
    {
        //camera ref setup
        camera = Camera.main.transform;
    }

    void Start()
    {
        previousCameraPos = camera.position;
        
        //assigning parallaxScaling
        parallaxScaleing = new float[scenery.Length];

        for (int i = 0; i < scenery.Length; i++)
        {
            parallaxScaleing[i] = scenery[i].position.z*-1;
        }
        
    }

    void Update()
    {
        //for each scenery

        for (int i = 0; i < scenery.Length; i++)
        {
            //parallax is opposite of cam movement because previous frame is multiplied by scale
            float parallax = (previousCameraPos.x - camera.position.x) *parallaxScaleing[i];
            
            //set target x position. current pos + parallax
            float sceneryTargetPosX = scenery[i].position.x + parallax;
            
            //create target pos which is scenery's current pos w/ it's tar x pos
            Vector3 sceneryTargetPos = new Vector3(sceneryTargetPosX, scenery[i].position.y, scenery[i].position.z);
            
            //fade between current pos and tar pos using lerp
            scenery[i].position =
                Vector3.Lerp(scenery[i].position, sceneryTargetPos, parallaxSmoothing * Time.deltaTime);
        }
        
        //set previousCameraPos to the camera's position at end of frame
        previousCameraPos = camera.position;
    }
}
