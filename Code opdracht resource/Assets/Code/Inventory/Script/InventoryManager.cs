using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventory;
	
	void Start ()
    {
        inventory.SetActive(false);
	}
	
	
	void Update ()
    {
        InvenManager();
	}

    void InvenManager()
    {
        if (Input.GetButtonDown("Inventory") && inventory.activeInHierarchy == false)
        {
            inventory.SetActive(true);
            GameObject.FindWithTag("Player").GetComponent<Movement>().enabled = false;
        }
        else
        {
            if (Input.GetButtonDown("Inventory") && inventory.activeInHierarchy == true)
            {
                inventory.SetActive(false);
                GameObject.FindWithTag("Player").GetComponent<Movement>().enabled = true;
            }
        }
    }
}
