using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

//from brackeys tutorial
public class WeaponBehaviour : MonoBehaviour
{

    public float fireRate = 0f;
    public float dmg = 10f;
    public LayerMask whatToHit;

    public Transform bulletTrail;

    private float timeToFire = 0f;
    private Transform firePoint;

    private void Awake()
    {
        firePoint = transform.Find("FirePoint");
        if (firePoint == null)
        {
            Debug.LogError("FirePoint not found");
        }
    }


    void Update()
    {
        if (fireRate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
               Shoot();
            }
        }
        else
        {
            if (Input.GetButton("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
    }

    private void Shoot()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
            Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition - firePointPosition, 100, whatToHit);
        Effect();
        Debug.DrawLine(firePointPosition, (mousePosition-firePointPosition)*100, Color.red);
        if (hit.collider != null)
        {
            Debug.DrawLine(firePointPosition, hit.point, Color.green);
            Debug.Log("We hit " + hit.collider.name + " and did " + dmg + " damage");
        }
    }

    private void Effect()
    {
        Instantiate(bulletTrail, firePoint.position, firePoint.rotation);
    }
}

