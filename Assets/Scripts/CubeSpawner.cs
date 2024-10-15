using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject Didis;

    public float spawnRate = 8;

    private float lastSpawnTime;

    void Start()
    {
        Instantiate(Didis);
    }

    void Update()
    {
        if (Time.time > lastSpawnTime + spawnRate)
        {
            Instantiate(Didis);
            lastSpawnTime = Time.time;
        }
    }
}
