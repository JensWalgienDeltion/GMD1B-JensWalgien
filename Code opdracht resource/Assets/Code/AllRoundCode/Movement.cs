using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 vec3;
    private float speed = 5f;
    private float hor;
    private float ver;

	void FixedUpdate ()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        transform.Translate(vec3 * Time.deltaTime * speed);
        vec3.x = hor;
        vec3.z = ver;
	}
}
