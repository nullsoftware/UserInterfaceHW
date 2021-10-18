using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        Debug.Log("Start game requested.");
        SceneManager.LoadScene("Game");
    }

    public void OnAboutButtonClick()
    {
        Debug.Log("About page requested.");
    }

    public void OnExitClick()
    {
        Debug.Log("Exit requested.");
        Application.Quit();
    }
}
