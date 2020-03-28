using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from Brackeys Tutorial

[RequireComponent(typeof(SpriteRenderer))]
public class TilingBehaviour : MonoBehaviour
{
    public int xOffset =2; //avoid weird errors

    public bool rightBuddy = false,
        leftBuddy = false; //instantiation check

    public bool reverseScale = false; //used for non tilable objs

    private float spriteWidth = 0f;
    private Camera camera;
    private Transform myTransform;

    private void Awake()
    {
        camera = Camera.main;
        myTransform = transform;
    }


    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteWidth = spriteRenderer.sprite.bounds.size.x;
    }

    void Update()
    {
        if (leftBuddy == false || rightBuddy == false)
        {
            //calculate half the width of what cam can see in world coords
            float camHorizontalExtend = camera.orthographicSize * Screen.width/Screen.height;
            
            //calculate x pos where cam can see edge of sprite (element)
            float visableEdgePosRight = (myTransform.position.x + spriteWidth / 2) - camHorizontalExtend;
            float visableEdgePosLeft = (myTransform.position.x - spriteWidth / 2) + camHorizontalExtend;
                //calculating if we can see edge of element and calling InstantiateNewBuddy if we can
            if (camera.transform.position.x >= visableEdgePosRight-xOffset&& rightBuddy == false)
            {
                InstantiateNewBuddy(1);
                rightBuddy = true;
            }
            else if (camera.transform.position.x <= visableEdgePosLeft + xOffset && leftBuddy == false)
            {
                InstantiateNewBuddy(-1);
                leftBuddy = true;
            }
        } 
    }
        //makes new buddy on required side
    private void InstantiateNewBuddy(int direction)
    {
        //calculating new pos for new buddy
        Vector3 newPos = new Vector3(myTransform.position.x+spriteWidth*direction, myTransform.position.y, myTransform.position.z);
        
        Transform newBuddy = Instantiate(myTransform, newPos, myTransform.rotation) as Transform;
        //reverses x scale for nontilable objects to make seams less noticable
        if (reverseScale==true)
        {
            newBuddy.localScale = new Vector3(newBuddy.localScale.x*-1,newBuddy.localScale.y,newBuddy.localScale.z);
        }

        newBuddy.parent = myTransform;
        if (direction > 0)
        {
            newBuddy.GetComponent<TilingBehaviour>().leftBuddy = true;
        }
        else
        {
            newBuddy.GetComponent<TilingBehaviour>().rightBuddy = true;
        }
    }
}
