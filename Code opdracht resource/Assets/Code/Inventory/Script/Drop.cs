using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public Inventory inv;
    public GameObject item;
    public bool drop;

    public void Update()
    {
        if (Input.GetButtonDown("Drop"))
        {
            if (drop)
            {
                inv.RemoveItem(item);
            }
        }
    }

    public void RemoveEnter()
    {
        drop = true;
    }

    public void RemoveExit()
    {
        drop = false;
    }
}
