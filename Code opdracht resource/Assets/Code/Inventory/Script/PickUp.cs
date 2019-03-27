using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int itemRoom;
    public Inventory inv;

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("PickUp") && other.gameObject.tag == "Item")
        {
            if(inv.items.Count < itemRoom)
            {
                Debug.Log("Picked up object");
                inv.AddItem(other.gameObject.GetComponent<ItemData>().item);
                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("You can't carry more.");
            }
        }
    }
}
