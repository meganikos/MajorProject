using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeScript : MonoBehaviour
{
    public GameObject Playagainbtn;
    public GameObject Gameover;
    public GameObject Exitbtn;
    public float timeStart;
    public TextMeshProUGUI textBox;
   
   
    void Start()
    {
        textBox.text = "Timer: " + timeStart.ToString("F0");
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenu.instance.GameIsPaused == false)
        {
            if (timeStart <= 0)
            {
                Playagainbtn.SetActive(true);
                Gameover.SetActive(true);
                Exitbtn.SetActive(true);
                Time.timeScale = 0f;

            }

            else
            {
                Playagainbtn.SetActive(false);
                Gameover.SetActive(false);
                Exitbtn.SetActive(false);

                Time.timeScale = 1f;

            }

            timeStart -= Time.deltaTime;
            textBox.text = "Timer: " + timeStart.ToString("F0");
        }
    }
    
   
}