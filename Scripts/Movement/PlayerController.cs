using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform blaster;
    public GameObject laserBolt;

    public GameManager gameManager;
    private PlayAudio playAudio;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Reference to Game Manager
        playAudio = GameObject.Find("AudioSource").GetComponent<PlayAudio>(); // Reference to Audio Source
    }

    // Update is called once per frame
    void Update()
    {
        //Set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep Player within bounds
        //Left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Gets space input from keyboard and assigns it to create laser. Second condition requires isGameOver to be false
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) 
        {
            //Creates laser at blaster position and maintains laser rotation
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);  

            // Play laser bolt sound effect
            if (playAudio != null)
            {
                playAudio.laserBolt();
            } 
        }
    }
}
