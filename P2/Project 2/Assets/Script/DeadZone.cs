using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {
    void OnCollisionEnter(Collision C)
    {
        Destroy(C.gameObject);
    }
	
	
}
