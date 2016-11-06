using UnityEngine;
using System.Collections;

public class SpawnBall : MonoBehaviour{

    public float power;
    public GameObject prefab;
    public GameObject pinballSpawn;

    public void SpawnPinball()
    {

        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.GetComponent<Transform>().position, pinballSpawn.GetComponent<Transform>().rotation);

        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.GetComponent<Transform>().transform.forward * power;
    }

}
