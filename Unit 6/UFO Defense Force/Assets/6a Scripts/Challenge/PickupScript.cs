using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{

    [SerializeField] private AudioSource pickupSoundEffect;
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") 
        {
            pickupSoundEffect.Play();
            print("Pickup obtained");
            Destroy(gameObject);
           
        }
    }
}
