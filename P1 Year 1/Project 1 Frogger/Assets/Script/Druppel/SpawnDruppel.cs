using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDruppel : MonoBehaviour {
    public GameObject prefab;
    public float min;
    public float max;
    public float height;
    public float z;
    public float counter;
    public float spawnrate;


    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= spawnrate)
        {
            spawncar();
            counter = 0;
        }
    }

    void spawncar()
    {
        Instantiate(prefab, new Vector3(Random.Range(min, max), height, z), Quaternion.identity);
    }
}
