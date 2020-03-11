using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class EnemyMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;

    public MovementData moveData;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        controller.Move(position* Time.deltaTime);
        position.x = moveData.moveSpeed;
    }

}
