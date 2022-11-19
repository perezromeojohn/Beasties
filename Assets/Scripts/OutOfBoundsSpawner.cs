using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsSpawner : MonoBehaviour
{
    private float bottomLimit = -15;
    public Rigidbody myObject;
    public float x, y, z;
    private bool isSpawning;
    // Update is called once per frame
   
    void Update()
    {
        if (transform.position.y < bottomLimit) // if it falls
        {
            myObject.rotation = Quaternion.identity;  // default rotation
            myObject.velocity = new Vector3(0, -10, 0); //  fixed velocity every spawn, to not retain fall velocity everytime it falls
            myObject.position = new Vector3(x, y, z); // default position
            myObject.transform.localScale = new Vector3(0, 0, 0); // default scale
            isSpawning = true;
        }

        if (isSpawning)
        {
            myObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f); // scale up
            if (myObject.transform.localScale.x >= 1) // if scale is 1
            {
                isSpawning = false;
            }
        }
    }

    private void FixedUpdate()
    {
        //continually decrease velocity
        // only at certain position
        if (transform.position.y > 3 && transform.position.y < 10)
        {
            myObject.velocity = myObject.velocity * 0.985f;

        }
    }
}

    


   
 