using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour {

    private Vector3 v;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        v.x += -Input.GetAxis("Mouse Y");
        v.x = Mathf.Clamp(v.x, -50.0f, 50.0f);
        transform.eulerAngles = (new Vector3(v.x, transform.eulerAngles.y, 0.0f));
    }
}
