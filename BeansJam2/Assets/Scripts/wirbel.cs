using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wirbel : MonoBehaviour {

    public GameObject[] objects;
    public Transform spawnPos;
    public Transform parent;

    void Start()
    {
        Instantiate(objects[Random.Range(0, 5)], spawnPos.position, spawnPos.rotation, parent);
    }
}
