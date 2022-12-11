using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{
    // serialize field for vector 3 position
    [SerializeField] private Vector3 position;
    // get the player object
    public GameObject player1;
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // set the camera's position to its current position
        // dynamic camera attached to player 1 and 2 while keeping the camera in the middle of the two players
        position.x = (player1.transform.position.x + player2.transform.position.x) / 2;
        position.y = (player1.transform.position.y + player2.transform.position.y) / 2;
        // offset the y position of the camera
        position.y += 15;
        // set the camera's position to the new position. interpolate for smooth movement
        transform.position = Vector3.Lerp(transform.position, position, 0.1f);
    }
}
