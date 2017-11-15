using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	void Start () {
        Time.timeScale = 0;
	}
	
	void Update () {
		
	}
    public void OnButtonPress()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    } 
}
