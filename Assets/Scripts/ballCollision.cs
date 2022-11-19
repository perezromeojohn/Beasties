using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollision : MonoBehaviour
{
    public float ballForce = 200;
    //get the Player 1 rigidbody
    public Rigidbody rb;
    // when the player collides with the ball, add force depending on the direction of the player
    void OnCollisionEnter(Collision collision)
    {
        // if the player hits the ball
        // add force to the ball relative to the direction of the player
        // if (collision.gameObject.name == "Player 1")
        // {
        //     rb = collision.gameObject.GetComponent<Rigidbody>();
        //     Vector3 direction = collision.gameObject.transform.position + transform.position;
        //     direction = direction.normalized;
        //     GetComponent<Rigidbody>().AddForce(direction * ballForce);
        // }

    }
    // Start is called before the first frame update
    void Start()
    {
        // get the rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
