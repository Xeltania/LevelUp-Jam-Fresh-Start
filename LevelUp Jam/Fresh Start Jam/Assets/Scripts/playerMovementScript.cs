using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    public float speed, jumpForce; // Movement values
    private int lookDir; // the direction of the sprite changes based on the button pressed
    public Rigidbody2D player;
    bool bFacingRight;
    bool bGrounded;
    GameObject audioSFX;
    public AudioClip tclip;

    private void Awake()
    {
        audioSFX = GameObject.Find("SFXSource");
        
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSFX.GetComponent<AudioSource>().clip = tclip;
        audioSFX.GetComponent<AudioSource>().mute = false;
        bFacingRight = true;
        speed = 1;
        bGrounded = true; // Used to check if the player is jumping

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Check the player movement
        checkMovement();
    }

    void checkMovement()
    {
        

        //Left
        if (Input.GetKey("a"))
        {
            //flip if not facing left
            if (bFacingRight)
            {
                transform.Rotate(0, -180, 0, Space.Self);
                bFacingRight = !bFacingRight;
            }
            // move by speed value
            walkSound();
            player.velocity = new Vector2(-speed, player.velocity.y);
        }
        //Right
        if (Input.GetKey("d"))
        {
            // flip if not facing right
            if (!bFacingRight)
            {
                transform.Rotate(0, 180, 0, Space.Self);
                bFacingRight = !bFacingRight;
            }
            // move by speed value
            walkSound();
            player.velocity = new Vector2(speed, player.velocity.y);
        }
        //Jump
        if (Input.GetKey("space"))
        {
        

        }
    }

    void walkSound()
    {
        if (bGrounded)
        {
            if (!audioSFX.GetComponent<AudioSource>().isPlaying)
                audioSFX.GetComponent<AudioSource>().Play();
        }
    }
}