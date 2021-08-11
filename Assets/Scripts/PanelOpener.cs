using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PanelOpener : MonoBehaviour
{
    public GameObject panel;
   



    public void OpenPanel()
    {
        if(panel != null)
        {
            bool isactive = panel.activeSelf;

            panel.SetActive(!isactive);

        }
       
    }

   
}
