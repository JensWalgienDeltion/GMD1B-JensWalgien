using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour {
    public string itemName;
    public int itemID;
    public string itemDescription;
    public Texture2D itemIcon;
    public int ItemPower;
    public int itemSpeed;
    public ItemType itemType;

    public enum ItemType
    {
        Weapon,
        Consumable,
        Quest
    }
    public Item(string name, int id, string description, int power, int speed, ItemType type)
    {
        itemName = name;
        itemID = id;
        itemDescription = description;
        itemIcon = Resources.Load<Texture2D>("Item Icons/" + name);
        ItemPower = power;
        itemSpeed = speed;
        itemType = type;
    }
    public Item()
    {

    }
}