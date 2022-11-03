using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{
    //Array
    public GameObject[] pickupPrefabs;

    private float spawnRangeX = 20f;

    private float spawnPosZ = 20f;

    private float startDelay = 2f;

    private float spawnInterval = 5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomPickup", startDelay, spawnInterval);
    }


    void Update()
    {

    }

    void SpawnRandomPickup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        
        int pickupIndex = Random.Range(0, pickupPrefabs.Length);

       
        Instantiate(pickupPrefabs[pickupIndex], spawnPos, pickupPrefabs[pickupIndex].transform.rotation);
    }
}
