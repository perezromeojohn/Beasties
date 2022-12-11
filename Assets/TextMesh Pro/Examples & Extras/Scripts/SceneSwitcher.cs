using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// scene management
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string[] sceneNames;

    public void LoadRandomScene()
    {
        // Generate a random index between 0 and the length of the sceneNames array
        int randomIndex = Random.Range(0, sceneNames.Length);

        // Get the name of the scene at the random index
        string sceneName = sceneNames[randomIndex];

        // Load the scene
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    public void Developer() {
        SceneManager.LoadScene("Developer");
    }

    public void Quit() {
        Application.Quit();
    }
}
