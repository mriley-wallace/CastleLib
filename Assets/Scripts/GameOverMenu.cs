using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu: MonoBehaviour
{
    // Start is called before the first frame update
   public void RetryGame()
    {
        SceneManager.LoadScene("ZombieShooter1");
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
