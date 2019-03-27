using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work : MonoBehaviour
{
    public Enum sleep;
    public Enum work;
    public List<GameObject> Npc = new List<GameObject>();
    public float degenSleep;
    public int maxNpc;

	void Start ()
    {
		
	}
    
    //npc's verliezen Sleep over tijd als ze werken
    void Update ()
    {
        if (Npc.Count != 0)
        {
            for (int i = 0; i < Npc.Count; i++)
            {
                Npc[i].GetComponent<Enum>().sleep -= Time.deltaTime * degenSleep;
                if (Npc[i].GetComponent<Enum>().sleep <= 25)
                {
                    Npc.RemoveAt(i);
                    i--;
                }
            }
        }
    }

    //kijkt of Npc.count lager is dan maxNpc als het lager is kan de npc erbij en als het hoger is kan de npc er niet bij
    public bool GoWork (GameObject player, bool check)
    {
        if (Npc.Count < maxNpc)
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
