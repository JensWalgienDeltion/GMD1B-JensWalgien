using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resource : MonoBehaviour
{
    public int resourceGet;
    public float resourceTime;
    public string houseString;

    public virtual void GetResource ()
    {

    }

    //roept aan of je resources kan krijgen
    public IEnumerator ResourceGet()
    {
        while (true)
        {
            if (GetComponent<Work>().Npc != null && GetComponent<Work>().Npc.Count != 0)
            {
                GetResource();
                GameObject.FindGameObjectWithTag(houseString).GetComponent<Build>().SetValues();
            }
            yield return new WaitForSeconds(resourceTime);
        }
    }
}
