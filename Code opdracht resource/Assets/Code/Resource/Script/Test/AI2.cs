using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI2 : MonoBehaviour
{
    public enum Mune {Idle, Walk, Gathering}
    public Mune mune;
    public Camera cam;
    public NavMeshAgent agent;
    public Vector3 posit;
	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
		switch (mune)
        {
            case Mune.Idle:
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit))
                    {
                        agent.SetDestination(hit.point);
                        posit = hit.point;
                        if (hit.transform.GetComponent<Resource>())
                        {
                            mune = Mune.Gathering;
                        }
                        else
                        {
                            mune = Mune.Walk;
                        }
                    }
                }
                break;
            case Mune.Walk:
                if (Vector3.Distance(transform.position, posit) < 1)
                {
                    mune = Mune.Idle;
                }
                break;
            case Mune.Gathering:
                if (Vector3.Distance(transform.position, posit) < 1)
                {
                    mune = Mune.Idle;
                }
                break;
        }
	}
}
