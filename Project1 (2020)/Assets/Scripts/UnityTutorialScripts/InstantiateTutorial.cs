//from Unity Tutorial
using UnityEngine;

public class InstantiateTutorial : MonoBehaviour
{
    public Rigidbody proj;
    public Transform cannonEnd;
    public float forceFloat = 500f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody projInstance;
            projInstance = Instantiate(proj, cannonEnd.position, cannonEnd.rotation) as Rigidbody;
            projInstance.AddForce(cannonEnd.forward *forceFloat);
        }
    }
}
