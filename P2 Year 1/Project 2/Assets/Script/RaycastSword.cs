using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastSword : MonoBehaviour {
    private RaycastHit hit;
    public GameObject impact;
    public GameObject g;

	
	void Update () {
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
            {
                if (hit.transform.tag == "Enemy")
                {
                    g = Instantiate(impact, hit.point, transform.rotation);
                    Destroy(g, 1);
                    hit.transform.gameObject.GetComponent<HealthScript>().loseHp(5);
                    
                }
            }
        }
    }
}
