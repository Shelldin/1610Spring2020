//From Brackeys Tutorial
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerPosition;
    public Vector3 cameraOffset;

    void Update()
    {
        transform.position = playerPosition.position + cameraOffset;
    }
}
