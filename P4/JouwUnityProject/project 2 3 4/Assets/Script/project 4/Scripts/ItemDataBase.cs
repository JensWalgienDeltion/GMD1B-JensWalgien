using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour{
    public List<Item> items = new List<Item>();

    void Start()
    {
        items.Add(new Item("Power Sword", 0, "An sword made of pure power", 2000, 100, Item.ItemType.Weapon));
        items.Add(new Item("Power Potion", 01, "An potion made of pure power", 0, 0, Item.ItemType.Consumable));
    }
}
