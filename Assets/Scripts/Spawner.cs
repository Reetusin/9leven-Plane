using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject towers;

    public float spawnRate = 2;

    private float lastSpawnTime;

    void Start()
    {
        Instantiate(towers);
    }

    void Update()
    {
        if(Time.time > lastSpawnTime + spawnRate)
        {
            Instantiate(towers);
            lastSpawnTime = Time.time;
        }
    }
}
