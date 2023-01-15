using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuOptions : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void PlayGame()
    {
        SceneManager.LoadScene(1); // Load the game scene
    }

    public void SetVolume(float volume) // Dynamically changes the main volume
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void EnterMenu()
    {
        SceneManager.LoadScene(0); // Load the main menu
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the application
    }
}
