using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        EndGame();


        scoreText.text = "Score: " + scoreValue;

    }

    public void EndGame()
    {
        if (scoreValue < 0) 
        {
            Debug.Log("GAME OVER");
        }
    }




}
