using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(CharacterController))]
public class EnemyPatrolCoroutine : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;

    public MovementData moveData;

    public UnityEvent moveStart,
        moveRepeat,
        moveEnd,
        shootStart,
        shootRepeat,
        shootEnd;

    private void FixedUpdate()
    {
        controller.Move(position* Time.deltaTime);
        position.x = moveData.moveSpeed;
    }

    private IEnumerator moveCoroutine,
        shootCoroutine;

    public float seconds = 1f;

    public GameObject projectileInstancerObj,
    spriteRendererObj;

    public int counter,
        counterReset,
        shotCount;

    private WaitForSeconds wfsObj;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        wfsObj = new WaitForSeconds(seconds);
        counterReset = counter;
    }

    public void CallMoveCoroutine()
    {
        moveCoroutine = MoveCoroutine();
        StartCoroutine(moveCoroutine);
    }

    public void CallShootCoroutine()
    {
        shootCoroutine = ShootCoroutine();
        StartCoroutine(shootCoroutine);
    }

    private void ResetCounter()
    {
        counter = counterReset;
    }

    IEnumerator MoveCoroutine()
    {

        moveStart.Invoke();
        while (counter > 0)
        { 
            moveRepeat.Invoke();
            yield return wfsObj;
            counter -= 1;
        }

        shotCount = 2;
        moveEnd.Invoke();
        
    }

    IEnumerator ShootCoroutine()
    {
        shootStart.Invoke();
        while (shotCount > 0)
        {
            shootRepeat.Invoke();
            yield return wfsObj;
            shotCount-= 1;
        }
        ResetCounter();
        shootEnd.Invoke();
    }


}
