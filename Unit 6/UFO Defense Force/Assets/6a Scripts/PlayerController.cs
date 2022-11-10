using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float verticalInput;

    public float speed = 25;

    public float xRange =27;

    public float zRange = 15;

    public Transform blaster;
    
    public GameObject laserBolt;

    public GameManager gameManager;

    

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void Update()
    {
        // Set HorizontalInput
        horizontalInput = Input.GetAxis("Horizontal");

        // Set VerticalInput
        verticalInput = Input.GetAxis("Vertical");

        // Moves Player left and right
        transform.Translate(Vector3.right *horizontalInput *Time.deltaTime * speed);

        // Moves Player up and down
        transform.Translate(Vector3.forward *verticalInput * Time.deltaTime * speed);

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

        // Top Side
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, zRange);
        }

        // Bottom Side
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        // Spacebar to fire laser bolt
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            // Create laser bolt at the blaster position
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);

            AudioManager.Instance.PlaySFX("Laser"); // Plays sound when laser bolt is fired
        }

        
    }

    //Delete any object with trigger that hits player
    private void OnTriggerEnter(Collider other) 
    {
        Destroy(other.gameObject);
    }
}
