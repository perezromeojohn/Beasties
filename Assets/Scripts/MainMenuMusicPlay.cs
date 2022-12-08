using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusicPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip music; // The music to play

    private AudioSource audioSource; // The AudioSource component

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component from the game object
        audioSource = GetComponent<AudioSource>();

        // Set the clip to play to the music we specified
        audioSource.clip = music;

        // Set the looping property of the AudioSource to true
        audioSource.loop = true;

        // Play the music
        audioSource.Play();
    }
}
