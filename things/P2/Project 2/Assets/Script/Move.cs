using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public Vector3 moves;
    public float hor;
    public float ver;
    public float speed;

    void FixedUpdate()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        moves.x = hor;
        moves.z = ver;
        transform.Translate(moves*Time.deltaTime*speed);



    }
}
