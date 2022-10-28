using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickups : MonoBehaviour
{
    public GameObject healthPickupPrefab;
    public float respawnTime = 1.0f;
    void Start()
    {
        StartCoroutine(pickupWave());
    }

    public void spawnPickup() 
    {
        GameObject a = Instantiate(healthPickupPrefab) as GameObject;
        a.transform.position = new Vector3(Random.Range(-30, 30), 0, 30);
    }
    IEnumerator pickupWave() 
    {
        while(true) 
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPickup();
        }
            
    }
}
