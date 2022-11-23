using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Team1Score : MonoBehaviour
{
    private int score;
    public GameObject goal;
    public GameObject canvas;
    // Start is called before the first frame update

 
    private void Update()
    {
        Transform textTr = canvas.transform.Find("team1_score");
        Text text = textTr.GetComponent<Text>();

        score = goal.GetComponent<GoalCollision>().getTeam1Score(); //initial score
        text.text = "Team 1: " + score.ToString();
    }

    // Update is called once per frame  
    
}
