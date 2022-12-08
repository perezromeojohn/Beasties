using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    // create movement variables
    public float moveSpeed = 5f;
    public Rigidbody rb;
    // get the tiresmoke particle system
    public ParticleSystem dust;
    public bool isGrounded = true;
    public float Horizontal = 0;
    public float Vertical = 0;

    // Start is called before the first frame update
    void Start()
    {
        // get the rigidbody component
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        playerMovement();
        playerRotation();
    }

    void playerMovement() {
        // get the input from the player
        Vector3 movement = new Vector3(Horizontal, 0f, Vertical).normalized;

        //check if the player has is not moving
        if (movement == Vector3.zero) {

            dust.Play();
        }
        // if w is pressed, set the Vertical to 1
        if (Input.GetKeyDown(KeyCode.W)) {
            Vertical = 1;
        }
        // if s is pressed, set the Vertical to -1
        if (Input.GetKeyDown(KeyCode.S)) {
            Vertical = -1;
        }
        
        // if a is pressed, set the Horizontal to -1
        if (Input.GetKeyDown(KeyCode.A)) {
            Horizontal = -1;
        }
        // if d is pressed, set the Horizontal to 1
        if (Input.GetKeyDown(KeyCode.D)) {
            Horizontal = 1;
        }

        // if w or s are released, set the Vertical to 0
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)) {
            Vertical = 0;
        }
        // if a or d are released, set the Horizontal to 0
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) {
            Horizontal = 0;
        }

        // move the player
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        // set animation to walk when key is pressed
        // if horizontal or vertical is not 0, set the animation to walk
        if (Horizontal != 0 || Vertical != 0) {
            GetComponent<Animator>().SetBool("isWalking", true);
        } else {
            GetComponent<Animator>().SetBool("isWalking", false);
        }
    }

    void playerRotation() {
        // rotate the player based on the input
        // do not rotate instantly, but over time depending on the direction
        // include 8 directions
        // simplify the above code

        Vector3 direction = new Vector3(Horizontal, 0f, Vertical);
        if (direction != Vector3.zero)
        {
           transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.15F);
        }
    }


}
