using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

/* The base item class. All items should derive from this. */

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject /* IDragHandler, IEndDragHandler*/
{

	new public string name = "New Item";	// Name of the item
	public Sprite icon = null;              // Item icon
    public string material = "New Item";
    public bool isDefaulItem = false;


    

    //// Call this method to remove the item from inventory
    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
       
    }

}
