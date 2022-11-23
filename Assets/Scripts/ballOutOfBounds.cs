using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballOutOfBounds : MonoBehaviour
{
    private float bottomLimit = -30;
    public Rigidbody Ball;
    public float x, y, z;
    private bool isSpawning;
    private bool velocityDecreaseStopper = false;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomLimit) // if it falls
        {
            if (Ball.name == "ball") // if the ball falls, then handle velocity
            {
                velocityDecreaseStopper = true;
            }
            Ball.angularVelocity = new Vector3(0.0f, 0.0f, 0.0f);  // remove spinning


            Ball.rotation = Quaternion.identity;  // default rotation
            Ball.velocity = new Vector3(0, -10, 0); //  fixed velocity every spawn, to not retain fall velocity everytime it falls
            Ball.position = new Vector3(x, y, z); // default position
            Ball.transform.localScale = new Vector3(0, 0, 0); // default scale
            isSpawning = true;
        }

        if (isSpawning)
        {
            Ball.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f); // scale up
            if (Ball.transform.localScale.x >= 2) // if scale is 1
            {
                isSpawning = false;
            }
        }
    }

    private void FixedUpdate()
    {
        //continually decrease velocity

        //if true
        //, then continue to decrease
        if (velocityDecreaseStopper)
        {
            Ball.velocity = Ball.velocity * 0.9969f;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        //if collided with terrain, therefore it already bounced once and doesnt need
        // velocity decrease
        if (collision.gameObject.name == "Terrain")
        {
            velocityDecreaseStopper = false;
        }
    }
}
