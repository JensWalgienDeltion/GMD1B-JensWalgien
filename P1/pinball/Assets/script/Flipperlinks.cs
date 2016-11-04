using UnityEngine;
using System.Collections;

public class Flipperlinks : MonoBehaviour
{

    public float flipperStrenght;
    public float pushForce;
    private HingeJoint hinge;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 f = transform.up * flipperStrenght;
            Vector3 p = (transform.right) + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
        }
    }
}

