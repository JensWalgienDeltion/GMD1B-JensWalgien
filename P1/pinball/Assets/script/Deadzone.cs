using UnityEngine;
using System.Collections;

public class Deadzone : MonoBehaviour {
    void OnCollisionEnter(Collision C)
    {
        Destroy(C.gameObject);
    }
}
