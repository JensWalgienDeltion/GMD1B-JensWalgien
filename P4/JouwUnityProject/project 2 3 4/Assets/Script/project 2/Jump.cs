using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    public Vector3 jump;
    public Rigidbody rb;
    public float playerHeight;

    void Awake()
    {
           rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Check of jump button gedrukt is en of we op de grond staan
        if (Input.GetButtonDown("Jump") && Grounded ())
        {
            Jumping();
        }
    }

    public void Jumping()
    {
        rb.velocity = jump;
    }

    private bool Grounded()
    {
        //Variable aanmaken voor hitinfo
        RaycastHit hit;

        //Stuur een raycast naar beneden en kijk of het iets raakt
        if(Physics.Raycast(transform.position, -transform.up, out hit, playerHeight))
        {
            //zoja, kijk of het de Ground tag heeft
            if(hit.collider.tag == "Ground")
            {
                Debug.Log("Jumping");
                return true;
            }
        }
        return false;
    }
}
