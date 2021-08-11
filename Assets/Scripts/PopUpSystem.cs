using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpSystem : MonoBehaviour
{
    [SerializeField]  Image PopUp;
    //public Animator animator;
    public TextMeshProUGUI text;

    GameObject PopUpbox;
    private ItemPickup itemPickup;
    //public Button removeButton;
    //bool isPressed;

    private void Awake()
    {
        itemPickup = GetComponent<ItemPickup>();
    }


    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == ("Player")) 
        {
           
            PopUp.enabled = true;
            text.enabled = true;

            if (itemPickup.ItemWasPickedUp)
            {
                PopUp.enabled = false;
                text.enabled = false;
            }
          

            
        }
        



    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            
            PopUp.enabled = false;
            text.enabled = false;

           



        }

    }







}
