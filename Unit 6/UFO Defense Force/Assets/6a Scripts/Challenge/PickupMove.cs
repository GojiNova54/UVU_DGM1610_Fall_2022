using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupMove : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    
   void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -speed);
        
    }

    
    void Update()
    {
        
    }
}
