using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMovement : MonoBehaviour {

    public Vector3 v;
    public Vector3 v2;
    public float sp;
    private float hor;
    private float ver;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        transform.Translate(v*Time.deltaTime*sp);
        v.x = hor;
        v.z = ver;
        v2.y = Input.GetAxis("Mouse X");
        v2.y = Mathf.Clamp(v2.y, -90, 90);
        transform.Rotate(v2);
    }
}
