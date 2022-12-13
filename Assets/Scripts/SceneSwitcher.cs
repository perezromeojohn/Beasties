using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// scene management
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] RectTransform fader;
    public string[] sceneNames;

    private void Start() {
        fader.gameObject.SetActive(true);

        LeanTween.scale(fader, new Vector3(1, 1, 1), 0);
        LeanTween.scale(fader, Vector3.zero, 0.5f).setOnComplete(() => {
            fader.gameObject.SetActive(false);
        });
    }

    public void LoadRandomScene()
    {
        // Generate a random index between 0 and the length of the sceneNames array
        int randomIndex = Random.Range(0, sceneNames.Length);

        // Get the name of the scene at the random index
        string sceneName = sceneNames[randomIndex];
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero, 0f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() => {
            // Load the scene
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        });
    }
    public void Developer() {
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero, 0f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() => {
            // Load the scene
            SceneManager.LoadScene("Developers 1", LoadSceneMode.Single);
        });
    }

    public void Settings() {
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero, 0f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() => {
            // Load the scene
            SceneManager.LoadScene("Settings", LoadSceneMode.Single);
        });
    }

    public void MainMenu() {
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader, Vector3.zero, 0f);
        LeanTween.scale(fader, new Vector3(1, 1, 1), 0.5f).setOnComplete(() => {
            // Load the scene
            SceneManager.LoadScene("Start Screen", LoadSceneMode.Single);
        });
    }

    public void Quit() {
        Application.Quit();
    }
    
}
