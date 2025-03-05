using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerMovement : MonoBehaviour
{
    //Variables
    public float speed = 5f;
    public float jumpSpeed = 4f; //Public means we can adjust in Unity.
    private float direction = 0f;
    private Rigidbody2D player;
    //variables to ensure we only can jump when we're on a platform
    public Transform groundCheck;
    public float groundCheckRadius;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        //2D Movement
        if(direction > 0f){ //Left-direction
            player.linearVelocity = new Vector2(direction*speed, player.linearVelocity.y); //Vector 2 can contain two params, x and y. 
        } else if(direction < 0f){ //Right-direction
            player.linearVelocity = new Vector2(direction*speed, player.linearVelocity.y); //Vector 2 can contain two params, x and y. 

        } else {
            player.linearVelocity = new Vector2(0, player.linearVelocity.y); //Vector 2 can contain two params, x and y. 
        }
        //Jump
        if(Input.GetButtonDown("Jump")){
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
        }
    }
}
