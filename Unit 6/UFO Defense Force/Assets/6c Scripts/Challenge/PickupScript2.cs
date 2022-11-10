using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript2 : MonoBehaviour
{
    

    

    
    

    public void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.tag == "Pickup")

            AudioManager.Instance.PlaySFX("Pickup"); // Plays sound when pickup is picked up
            Destroy(collider.gameObject);
    }


}
