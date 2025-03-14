using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the next scene in the build index
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void LoadMenu()
    {
        // Load the main menu scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    public void RestartGame()
    {
        // Restart the game
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}

