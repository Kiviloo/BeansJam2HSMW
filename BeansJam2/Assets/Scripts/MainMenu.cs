using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

	public void OnStart()
    {
        SceneManager.LoadScene("Ingame"); // SceneManager.LoadScene("Game");
    }

    public void OnCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
