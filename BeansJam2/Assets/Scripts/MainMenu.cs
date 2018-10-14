using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    public AudioSource source;

	public void OnStart()
    {
        source.Play();
        StartCoroutine(StartWait());
    }

    public void OnCredits()
    {
        source.Play();
        StartCoroutine(CreditWait());
    }

    IEnumerator StartWait()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Ingame");
    }

    IEnumerator CreditWait()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Credits");
    }

    public void OnQuit()
    {
        source.Play();
        Application.Quit();
    }
}
