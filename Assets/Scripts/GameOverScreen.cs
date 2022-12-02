using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public Text team1scoreText;
    public Text team2scoreText;
    public GoalCollision goal1;
    public GoalCollision goal2;
    public void Setup()
    {
        gameObject.SetActive(true);

        team1scoreText.text = "Team 1: " + goal1.getScore().ToString();
        team2scoreText.text = "Team 2: "+ goal2.getScore().ToString();
        goal1.stopPlayingOnGameOverToggle();
        goal2.stopPlayingOnGameOverToggle();
    }

    public void Restart()
    {
        Debug.Log("clicked");
        goal1.stopPlayingOnGameOverToggle();
        goal2.stopPlayingOnGameOverToggle();
        SceneManager.LoadScene("Test Scene");
    
    }
}
    