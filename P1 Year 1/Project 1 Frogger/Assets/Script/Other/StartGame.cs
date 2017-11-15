using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnButtonPress()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    } 
}
