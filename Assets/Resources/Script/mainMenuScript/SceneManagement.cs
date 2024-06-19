using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void changeToIngameScene()
    {
        SceneManager.LoadScene("inGameScene");
        Debug.Log("inGameScene Loaded");
        StopAudio();
    }

    void StopAudio()
    {
        // Check if audioSource is valid
        if (audioSource != null)
        {
            // Stop the audio playback
            audioSource.Stop();
        }
        else
        {
            Debug.LogWarning("No AudioSource attached or AudioSource is null.");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }


}