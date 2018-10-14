using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	
	void Start () {

        StartCoroutine(DeathWaiter());
    }

    IEnumerator DeathWaiter()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("MainMenu");
    }
}
