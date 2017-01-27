using UnityEngine;
using System.Collections;

public class Firstperson : MonoBehaviour {
    public Vector3 rotationes;
    public Vector3 camrotations;
    public GameObject cam;
    public int camspeedver;
    public int camspeedhor;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        rotationes.y = Input.GetAxis("Mouse X");
        camrotations.x = Input.GetAxis("Mouse Y");
        transform.Rotate(rotationes * camspeedhor * Time.deltaTime);
        cam.transform.Rotate(-camrotations * camspeedver * Time.deltaTime);

    }
}
