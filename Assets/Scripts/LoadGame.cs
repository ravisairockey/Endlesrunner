using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour

{
    public void StartGame()
    {
        SceneManager.LoadScene("Game"); // Load the scene named "Game"
    }
}

