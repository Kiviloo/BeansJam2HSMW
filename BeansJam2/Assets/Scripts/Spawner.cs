using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject objects;
    public Transform spawnPos;

    void OnEnable()
    {
        Instantiate(objects, spawnPos.position, spawnPos.rotation);
    }
}
