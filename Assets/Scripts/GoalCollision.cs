using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollision : MonoBehaviour
{
    public GameObject ring;
    private int team1score =0;
    private int team2score =0;


    private void OnTriggerEnter(Collider other)
    {
   
        if (other.gameObject.name == "ball") //ball goes innnnnnn
        {
           
            if (ring.name == "Team1")
            {
                team1score++;
                Debug.Log("team1 "+ team1score);

            }
            if (ring.name == "Team2")
            {
                team2score++;
                Debug.Log("team1 " + team2score);
            }

        }
    }
 



    public int getTeam1Score()
    {
        return team1score;
    }
    public int getTeam2Score()
    {
        return team2score;
    }
}
