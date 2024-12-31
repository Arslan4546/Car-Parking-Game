using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadinScript : MonoBehaviour
{
    public float delay = 3.0f; // Time to wait before transitioning

    void Start()
    {
        // Load the main menu scene after the delay
        Invoke("LoadMainMenu", delay);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("Starting"); // Replace with the exact name of your main menu scene
    }
}
