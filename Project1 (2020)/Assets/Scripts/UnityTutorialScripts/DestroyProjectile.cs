//from unity tutorial
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    public float seconds = 5f;
    private void Start()
    {
        Destroy(gameObject, seconds);
    }
}
