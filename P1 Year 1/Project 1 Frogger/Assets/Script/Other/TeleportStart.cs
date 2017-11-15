using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportStart : MonoBehaviour {
    public Vector3 v;
    public GameObject g;


    void OnCollisionEnter(Collision c)
    {
        v.y = 0;
        c.gameObject.transform.position = g.transform.position;
    }
}
