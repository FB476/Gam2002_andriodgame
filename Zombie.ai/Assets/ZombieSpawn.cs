using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public GameObject[] spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject", spawnTime, spawnDelay);
    }

    public void spawnObject()
    {
        int index = Random.Range(0, spawnee.Length);
        Instantiate(spawnee[index], transform.position, transform.rotation);
    }
}
