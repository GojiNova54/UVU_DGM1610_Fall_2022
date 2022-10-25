using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 25;

    public float xRange =27;

    public Transform blaster;
    
    public GameObject laserBolt;
    

    
    void Update()
    {
        // Set HorizontalInput
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right
        transform.Translate(Vector3.right *horizontalInput *Time.deltaTime * speed);

        //Keep Player within bounds
        //Left Side
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //Right Side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Spacebar to fire laser bolt
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            // Create laser bolt at the blaster position
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }

        
    }

    //Delete any object with trigger that hits player
    private void OnTriggerEnter(Collider other) 
    {
        Destroy(other.gameObject);
    }
}
