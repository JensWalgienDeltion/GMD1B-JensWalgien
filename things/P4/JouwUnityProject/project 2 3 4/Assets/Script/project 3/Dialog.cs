using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour {
    private bool showTalk;
    public string[] tekst;
    public Text textvak;
	void Start () {
        textvak.text = tekst[0];
	}
	
	void Update () {

	}
    public void Button()
    {
        textvak.text = tekst[1];
    }
    public void Button2()
    {
        textvak.text = tekst[2];
    }
}
