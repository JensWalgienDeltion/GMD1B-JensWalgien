using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    /*
    public int damage;
    public GameObject[] target;
    public Resource[] hpCount;
    bool doDamage;
	
	void Start ()
    {
        
	}
	
	
	void Update ()
    {
        target = GameObject.FindGameObjectsWithTag("Resource");
        hpCount = target[0].GetComponents<Resource>();
    }

    void OnTriggerStay(Collider other)
    {
        if (!doDamage)
        {
            StartCoroutine(MyCoroutine());
            Debug.Log("asd");
        }
    }

    IEnumerator MyCoroutine ()
    {
        doDamage = true;
        yield return new WaitForSeconds(1);
        doDamage = false;
        hpCount[0].hpCount -= damage;
    }

    */
}
