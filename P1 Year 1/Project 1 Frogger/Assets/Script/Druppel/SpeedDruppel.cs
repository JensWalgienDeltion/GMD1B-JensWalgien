using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDruppel : MonoBehaviour {
    public Vector3 druppelMove;
    public float speed;


    void Start()
    {


    }


    void Update()
    {
        transform.Translate(druppelMove * speed);

    }
}
