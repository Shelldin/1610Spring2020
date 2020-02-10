using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;

    public MovementData PlayerMoveData;
    public FloatData health;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        controller.Move(position * Time.deltaTime);
        position.x = PlayerMoveData.moveSpeed * Input.GetAxis("Horizontal");

        if (!controller.isGrounded)
        {
            position.y -= PlayerMoveData.gravity;
        }
        else
        {
            PlayerMoveData.jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && PlayerMoveData.jumpCount < PlayerMoveData.jumpCountMax)
        {
            PlayerMoveData.jumpCount++;
            position.y = PlayerMoveData.jumpSpeed;
        }
        

        if (transform.position.y <= -10f || health.value <= 0f)
        {
            FindObjectOfType<StateManager>().GameOver();
        }
    }

}
