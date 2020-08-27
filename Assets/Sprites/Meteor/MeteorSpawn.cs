using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour
{
    public GameObject [] MeteorPrefab;
    public float MinSpawnDelay = 1f;
    public float MaxSPawnDelay = 3f;
    public float SpawnXLimit = 6f;
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Spawn()
    {
        float random = Random.Range(-SpawnXLimit, SpawnXLimit);
        Vector3 spawnPosition = transform.position + new Vector3(random, 0f, 0f);
        Instantiate(MeteorPrefab[Random.Range(0, MeteorPrefab.Length)], spawnPosition, Quaternion.identity);
        Invoke("Spawn", Random.Range(MinSpawnDelay, MaxSPawnDelay));
    }
}
