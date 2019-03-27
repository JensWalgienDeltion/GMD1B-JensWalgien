using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enum : MonoBehaviour
{
    public enum Mune {Sleep, Work}
    public Mune mune;
    public NavMeshAgent agent;
    public float sleep = 100;
    public List<Transform> house = new List<Transform>();
    public List<Transform> work = new List<Transform>();

	void Start ()
    {

	}
	
	//de opties die de npc's hebben om te doen
	void Update ()
    {
		switch (mune)
        {
            case Mune.Sleep:
                if(sleep >= 75)
                {
                    GoWork();
                    mune = Mune.Work;
                }
            break;

            case Mune.Work:
                if (sleep <= 25)
                {
                    GoSleep();
                    mune = Mune.Sleep;
                }
            break;
        }
	}

    /*
     * zoek naar een huis die in de lijst staat wanneer sleep onder het genoemde nummer is
     * als de npc het 3x heeft geprobeerd om een huis te zoeken en het lukt niet dan zal het weer gaan werken
    */
    void GoSleep ()
    {
        GameObject[] tempthouse = GameObject.FindGameObjectsWithTag("House");
        house = new List<Transform>();
        foreach (GameObject houseplace in tempthouse)
        {
            house.Add(houseplace.transform);
        }
        int index = Random.Range(0, house.Count);
        int tries = 3;
        while (!tempthouse[index].GetComponent<House>().GoSleep(gameObject, true) && tries > 0)
        {
            index = Random.Range(0, house.Count);
            tries--;
            if(tries == 0)
            {
                mune = Mune.Work;
            }
        }
        agent.SetDestination(house[index].position);
        StartCoroutine(GoingToHouse(tempthouse[index]));
    }

    public IEnumerator GoingToHouse (GameObject houseSleep)
    {
        while(Vector3.Distance(houseSleep.transform.position, transform.position) >= 4)
        {
            yield return null;
        }
        houseSleep.GetComponent<House>().GoSleep(gameObject, false);
    }

    /*
     * zoek naar werk die in de lijst staat wanneer sleep hoog genoeg is om te werken
     * als de npc het 3x heeft geprobeerd om een huis te zoeken en het lukt niet dan zal het weer gaan slapen
    */
    void GoWork ()
    {
        GameObject[] temptwork = GameObject.FindGameObjectsWithTag("Work");
        work = new List<Transform>();
        foreach(GameObject workplace in temptwork)
        {
            work.Add(workplace.transform);
        }
        int index = Random.Range(0, work.Count);
        int tries = 3;
        while (!temptwork[index].GetComponent<Work>().GoWork(gameObject, true) && tries > 0)
        {
            index = Random.Range(0, work.Count);
            tries--;
            if (tries == 0)
            {
                mune = Mune.Sleep;
            }
        }
        agent.SetDestination(work[index].position);
        StartCoroutine(GoingToWork(temptwork[index]));
    }

    public IEnumerator GoingToWork (GameObject workGoing)
    {
        while (Vector3.Distance(workGoing.transform.position, transform.position) >= 4)
        {
            yield return null;
        }
        workGoing.GetComponent<Work>().GoWork(gameObject, false);
    }
}
