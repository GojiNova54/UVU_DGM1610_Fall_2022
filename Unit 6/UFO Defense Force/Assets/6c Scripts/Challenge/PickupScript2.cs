using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript2 : MonoBehaviour
{
    [SerializeField] private AudioSource pickupSoundEffect;

    public void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.tag == "Pickup")

            pickupSoundEffect.Play();
            Destroy(collider.gameObject);
    }


}
