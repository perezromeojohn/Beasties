using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// scene management
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("Test Scene");
    }
}
