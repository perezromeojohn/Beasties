using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollision : MonoBehaviour
{
    public GameObject ring;
    private int score =0;
    private int team2score =0;
    private bool stopPlaying = false;

    private void OnTriggerEnter(Collider other)
    {
   
        if (other.gameObject.name == "ball" && !stopPlaying) //ball goes innnnnnn
        {
            score++;
           // if (ring.name == "Team1")
            //{
            //    team1score++;
            //    Debug.Log("team1 "+ team1score);

            //}
            //if (ring.name == "Team2")
            //{
            //    team2score++;
            //    Debug.Log("team1 " + team2score);
           // }

        }
    }
 

        

    public int getScore()
    {
        return score;
    }
    public int getTeam2Score()
    {
        return team2score;
    }
    public void stopPlayingOnGameOverToggle()
    {
        stopPlaying = !stopPlaying;
    }
}
