using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


/* Sits on all InventorySlots. */

public class InventorySlot : MonoBehaviour, IDragHandler, IEndDragHandler,IDropHandler
{
    AudioSource audio;

    [Header("Audio Clips")]
    public AudioClip CorrectSound;
    public AudioClip WrongSound;

    public Image icon;

    public Button removeButton;

    Item item;  // Current item in the slot

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlasticBin"))
        {
            //TODO
            //IF MATERIAL NAME OF SCRIPTABLE OBJECT IS PLASTIC DESTROY IT

            if (item.material == "plastic")
            {
                ScoreScript.scoreValue += 10;
                icon.sprite = null;
                icon.enabled = false;
                removeButton.interactable = false;
                RemoveItemFromInventory();
                Debug.Log("Destroy Plastic");
                audio.PlayOneShot(CorrectSound);
            }
            else
            {
                Debug.Log("Wrong bin");
                ScoreScript.scoreValue -= 10;
                audio.PlayOneShot(WrongSound);
            }
            

        }


        if (collision.gameObject.CompareTag("GlassBin"))
        {
            //TODO
            //IF MATERIAL NAME OF SCRIPTABLE OBJECT IS GLASS DESTROY IT

            if (item.material == "glass")
            {
                ScoreScript.scoreValue += 10;
                icon.sprite = null;
                icon.enabled = false;
                removeButton.interactable = false;
                RemoveItemFromInventory();
                Debug.Log("Destroy Glass");
                audio.PlayOneShot(CorrectSound);
            }
            else
            {
                Debug.Log("Wrong bin");
                ScoreScript.scoreValue -= 10;
                audio.PlayOneShot(WrongSound);
            }


        }

        if (collision.gameObject.CompareTag("CompostBin"))
        {
            //TODO
            //IF MATERIAL NAME OF SCRIPTABLE OBJECT IS COMPOST DESTROY IT

            if (item.material == "compost")
            {
                ScoreScript.scoreValue += 10;
                icon.sprite = null;
                icon.enabled = false;
                removeButton.interactable = false;
                RemoveItemFromInventory();
                Debug.Log("Destroy compost");
                audio.PlayOneShot(CorrectSound);
            }
            else
            {
                Debug.Log("Wrong bin");
                ScoreScript.scoreValue -= 10;
                audio.PlayOneShot(WrongSound);
            }


        }



        if (collision.gameObject.CompareTag("PaperBin"))
        {
            //TODO
            //IF MATERIAL NAME OF SCRIPTABLE OBJECT IS PAPER DESTROY IT

            if (item.material == "paper")
            {
                ScoreScript.scoreValue += 10;
                icon.sprite = null;
                icon.enabled = false;
                removeButton.interactable = false;
                RemoveItemFromInventory();
                Debug.Log("Destroy Paper");
                audio.PlayOneShot(CorrectSound);
            }
            else
            {
                Debug.Log("Wrong bin");
                ScoreScript.scoreValue -= 10;
                audio.PlayOneShot(WrongSound);
            }
            

        }
        

        if (collision.gameObject.CompareTag("MetalBin"))
        {
            //TODO
            //IF MATERIAL NAME OF OBJECT IS METAL DESTROY IT
            if (item.material == "metal")
            {
                ScoreScript.scoreValue += 10;
                icon.sprite = null;
                icon.enabled = false;
                removeButton.interactable = false;
                RemoveItemFromInventory();
                Debug.Log("Destroy Metal");
                audio.PlayOneShot(CorrectSound);
            }
            else
            {
                Debug.Log("Wrong bin");
                ScoreScript.scoreValue -= 10;
                audio.PlayOneShot(WrongSound);
            }
        }




    }

    // Add item to the slot
    public void AddItem (Item newItem)
	{
		item = newItem;

		icon.sprite = item.icon;
		icon.enabled = true;
        removeButton.interactable = true;
    }

	// Clear the slot
	public void ClearSlot ()
	{
		item = null;

		icon.sprite = null;
		icon.enabled = false;
        removeButton.interactable = false;
    }

    //Drag Item
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
       
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
    }

    public void OnDrop(PointerEventData eventData)
    {
        transform.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
    }

    // If the remove button is pressed, this function will be called.
    public void RemoveItemFromInventory()
    {
        Inventory.instance.Remove(item);
    }

   

}
