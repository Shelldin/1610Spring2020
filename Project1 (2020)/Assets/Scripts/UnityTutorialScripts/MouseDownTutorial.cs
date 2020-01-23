// from unity tutorial
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class MouseDownTutorial : MonoBehaviour
{

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        rb.AddForce(transform.up *1000f);
        rb.useGravity = true;
    }

}
