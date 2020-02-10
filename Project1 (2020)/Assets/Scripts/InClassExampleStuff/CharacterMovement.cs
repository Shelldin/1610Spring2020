
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;

    public float speed = 10f,
        gravity = -3f,
        jumpForce = 30f;

    public int jumpCountMax = 2;

    private Vector3 positionDirection;
    private int jumpCount = 0;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }
        
        positionDirection.x = Input.GetAxis("Horizontal")*speed;
        
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;
        }
        
        positionDirection.y += gravity;
        controller.Move(positionDirection *Time.deltaTime);

        
        
    }
}
