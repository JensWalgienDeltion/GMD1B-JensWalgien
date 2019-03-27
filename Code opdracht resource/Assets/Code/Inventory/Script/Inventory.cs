using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject[] image;
    public List<Item> items = new List<Item>();
    public Text info;

    public void AddItem(Item itemAdd)
    {
        items.Add(itemAdd);
        CheckItem();
    }

    public void RemoveItem(GameObject itemRemove)
    {
        for (int i = 0; i < image.Length; i++)
        {
            if(itemRemove == image[i])
            {
                if(i < items.Count)
                {
                    Instantiate(items[i].item, transform.position, Quaternion.identity);
                    items.RemoveAt(i);
                    CheckItem();
                    break;
                }
            }
        }
    }

    public void CheckItem()
    {
        for (int i = 0; i < image.Length; i++)
        {
            if(i < items.Count)
            {
                image[i].GetComponent<Image>().sprite = items[i].sprite;
            }
            else
            {
                image[i].GetComponent<Image>().sprite = null;
            }
        }
    }

    public void InfoItem(GameObject itemInfo)
    {
        for (int i = 0; i < image.Length; i++)
        {
            if (itemInfo == image[i])
            {
                if(i < items.Count)
                {
                    info.text = items[i].info;
                    break;
                }
            }
        }
    }

    public void RemoveInfoItem(GameObject itemInfoRemove)
    {
        for (int i = 0; i < image.Length; i++)
        {
            if (itemInfoRemove == image[i])
            {
                if (i < items.Count)
                {
                    info.text = "";
                    break;
                }
            }
        }
    }
}
