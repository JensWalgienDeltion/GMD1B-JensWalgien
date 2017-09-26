using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
    public Vector3 a;
    public bool b;
    public float c;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update(){
        transform.position = a;
        if(b == true)
        {
            a.y =+ c;
        }
        if (Input.GetButtonDown("Jump")) { }
    }
    
}
