using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : Resource
{
    
	
	void Start ()
    {
        StartCoroutine(ResourceGet());
	}
	
	
	void Update ()
    {

    }

    //geeft het aantal resources voor het aatal npc's die er zijn
    public override void GetResource()
    {
        GameObject.FindGameObjectWithTag(houseString).GetComponent<Build>().wood += Mathf.RoundToInt(GetComponent<Work>().Npc.Count * resourceGet);
    }
}
