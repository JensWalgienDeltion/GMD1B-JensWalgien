using UnityEngine;
using System.Collections;

public class Firstperson : MonoBehaviour {
    float xRot;
    float yRot;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        yRot = Input.GetAxis("Mouse X");
        xRot = Input.GetAxis("Mouse Y");

        transform.Rotate(new Vector3(-xRot, 0, 0));
        transform.parent.Rotate(new Vector3(0, yRot, 0));
    }
}
