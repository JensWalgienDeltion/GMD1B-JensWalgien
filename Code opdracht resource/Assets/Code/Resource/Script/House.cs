using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public Enum sleep;
    public List<GameObject> Npc = new List<GameObject>();
    public float regenSleep;
    public int maxNpc;
	
	void Start ()
    {
		
	}
	
	
    //npc's krijgen Sleep over tijd als ze slapen
	void Update ()
    {
        if (Npc.Count != 0)
        {
            for (int i = 0; i < Npc.Count; i++)
            {
                Npc[i].GetComponent<Enum>().sleep += Time.deltaTime * regenSleep;
                if (Npc[i].GetComponent<Enum>().sleep >= 75)
                {
                    Npc.RemoveAt(i);
                    i--;
                }
            }
        }
	}

    //kijkt of Npc.count lager is dan maxNpc als het lager is kan de npc erbij en als het hoger is kan de npc er niet bij
    public bool GoSleep (GameObject player, bool check)
    {
        if(Npc.Count < maxNpc)
        {
            if (!check)
            {
                Npc.Add(player);
            }
            return true;
        }
        return false;
    }
}
