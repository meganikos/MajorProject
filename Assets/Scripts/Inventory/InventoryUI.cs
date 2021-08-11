using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

/* This script manages the inventory UI. */

public class InventoryUI : MonoBehaviour {

    //public GameObject inventoryUI;	// The entire UI
    public Transform itemsParent;   // The parent object of all the items

    Inventory inventory;	// Our current inventory

    public InventorySlot[] slots;

   

	void Start ()
	{
		inventory = Inventory.instance;
		inventory.onItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
	}

   
    // Update the inventory UI by:
    //		- Adding items
    //		- Clearing empty slots
    // This is called using a delegate on the Inventory.
    public void UpdateUI ()
	{
        Debug.Log("Added to inventory!");
        //InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();

        

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }

    
}
