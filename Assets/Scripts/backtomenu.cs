using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtomenu : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene("ui"); // Load the scene named "ui" (replace with your menu scene's name)
    }
}
