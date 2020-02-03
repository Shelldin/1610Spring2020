
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 10f,
        gravity = -3f,
        jumpForce = 30f;

    private Vector3 positionDirection;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            positionDirection.y = jumpForce;
        }
        
        positionDirection.y += gravity;
        controller.Move(positionDirection *Time.deltaTime);

        
        
    }
}
