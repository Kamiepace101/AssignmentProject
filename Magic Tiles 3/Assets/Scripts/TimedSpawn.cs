using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public GameObject spawner;
    public bool _stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    [SerializeField]
    private Transform[] spawnPos;
    int randomInt;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        int randPosition = Random.Range(0,spawnPos.Length);
        Instantiate(spawner,spawnPos[randPosition].position,Quaternion.identity);
    }

    public void StopSpawning()
    {
        Debug.Log("IT should stop spawning");
        CancelInvoke("SpawnObject");
    }
}