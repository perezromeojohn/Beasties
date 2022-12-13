using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToTitle : MonoBehaviour
{
    // write a start function that will load the title screen after 5 seconds
    void Start()
    {
        StartCoroutine(Transition());
    }

    IEnumerator Transition()
    {
        yield return new WaitForSeconds(14);
        SceneManager.LoadScene("Start Screen");
    }
}
