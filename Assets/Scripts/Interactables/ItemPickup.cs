using UnityEngine;
using System.Collections;

public class ItemPickup : Interactable {

    public Item item;   // Item to put in the inventory if picked up
    PopUpSystem PopUp;

    [HideInInspector] public bool ItemWasPickedUp;
    // When the player interacts with the item
    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    // Pick up the item
    public void PickUp()
	{
		Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);   // Add to inventory

        if (wasPickedUp)
        {
            StartCoroutine(DestroyObjAfterSec());
            ItemWasPickedUp = true;
        }
      
	}


    IEnumerator DestroyObjAfterSec() //Destroy object in  inventory UI
    {
        yield return new WaitForSeconds(0.01f);
        Destroy(gameObject);
    }

}
