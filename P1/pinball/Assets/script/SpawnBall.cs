using UnityEngine;
using System.Collections;

public class SpawnBall : MonoBehaviour {
    public float power;
    public GameObject prefab;
    public GameObject Spawnball;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPinball();
        }
    }

    void SpawnPinball()
    {
        GameObject pinball = (GameObject)Instantiate(prefab, Spawnball.GetComponent<Transform>().position, Spawnball.GetComponent<Transform>().rotation);


            pinball.GetComponent<Rigidbody>().velocity = transform.forward * power;
    
    }
}
