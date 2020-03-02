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

    private IEnumerator moveCoroutine,
        fireCoroutine;

    public float seconds = 1f;

    public GameObject projectileInstancerObj,
    spriteRendererObj;

    public int counter;

    private WaitForSeconds wfsObj;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        wfsObj = new WaitForSeconds(seconds);
    }

    public void CallMoveCoroutine()
    {
        moveCoroutine = MoveCoroutine();
        StartCoroutine(moveCoroutine);
    }

    IEnumerator MoveCoroutine()
    {

        controller.Move(position * Time.deltaTime);
        position.x = moveData.moveSpeed;
        while (counter > 0)
        { 
            controller.Move(position * Time.deltaTime);
            position.x = moveData.moveSpeed; 
            yield return wfsObj;
            counter -= 1;
        }
        moveEnd.Invoke();
        
    }


}
