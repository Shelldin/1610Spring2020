using UnityEngine;
[CreateAssetMenu]
public class MovementData : GameArtData
{
    public float moveSpeed = 10f,
        gravity = 3f,
        maxGravity = 10f,
        jumpSpeed = 30f;

    public int jumpCountMax = 2,
        jumpCount = 0;

    public void UpdateMoveSpeed(float amount)
    {
        moveSpeed += amount;
    }

    public void UpdateGravity(float amount)
    {
        gravity += amount;
    }

    public void SetGravity(float amount)
    {
        gravity = amount;
    }

    public void UpdateJumpSpeed(float amount)
    {
        jumpSpeed += amount;
    }

    public void UpdateJumpCountMax(int amount)
    {
        jumpCountMax += amount;
    }

    public void ReverseMoveSpeed()
    {
        moveSpeed *= -1;
    }

    public void SetMoveSpeed(float amount)
    {
        moveSpeed = amount;
    }
}
