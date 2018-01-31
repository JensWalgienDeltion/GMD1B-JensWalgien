using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour {
    public int hp;
    
    public void loseHp(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            Destroy(gameObject, 0);
        }
    }
        
}
