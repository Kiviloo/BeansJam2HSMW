using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject[] objectSpawner;
    public float timeSchneller;
    public int anfangsZeit;
    public float basisZeit;

    void Start()
    {
        StartCoroutine(Baelle());
        
    }

    IEnumerator WelcherSpawner()
    {

        for (int i = 0; i < 10000; i++)
        {
            int ran = Random.Range(0, 4);
            yield return new WaitForSeconds(basisZeit);
            objectSpawner[ran].SetActive(true);
            objectSpawner[ran].SetActive(false);
            basisZeit = basisZeit - timeSchneller;
        }
    }

    IEnumerator Baelle()
    {
        yield return new WaitForSeconds(anfangsZeit);
        StartCoroutine(WelcherSpawner());
    }
}
