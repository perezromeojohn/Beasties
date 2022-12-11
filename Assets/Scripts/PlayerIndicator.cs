using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIndicator : MonoBehaviour
{
    [SerializeField] GameObject player;
    public GameObject indicator;
    public int offset = 3;

    // Update is called once per frame
    void Update()
    {
        // get the position of the player
        Vector3 playerPos = player.transform.position;
        // set the position of the indicator to the player's position, add 20 to y to make it appear above the player
        indicator.transform.position = new Vector3(playerPos.x, playerPos.y + offset, playerPos.z);

        // if the gameobject scale is 2, offset++ til it reaches 5
        // while (player.transform.localScale.x == 2)
        // {
        //     offset++;
        //     if (offset == 5)
        //     {
        //         break;
        //     }
        // }

        // // if the gameobject scale is 2, offset-- til it reaches 3
        // while (player.transform.localScale.x == 1)
        // {
        //     offset--;
        //     if (offset == 3)
        //     {
        //         break;
        //     }
        // }
        if (player.transform.localScale.x == 2)
        {
            offset = 5;
        }
        else if (player.transform.localScale.x == 1)
        {
            offset = 3;
        }
    }
}
