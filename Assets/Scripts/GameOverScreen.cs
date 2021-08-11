using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameOverScreen : MonoBehaviour
{
    

    public void RestartScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    
    }

    public void PlayParkLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void PlaySchoolLevel()
    {
        SceneManager.LoadScene(2);
    }


   public void ExitGame()
   {
        Application.Quit();
        Debug.Log("EXIT!");
   }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
