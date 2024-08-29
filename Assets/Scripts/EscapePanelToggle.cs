using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapePanelToggle : MonoBehaviour
{
    public GameObject panelToToggle; // Drag the UI Panel GameObject here in the Inspector
    private bool isGamePaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
            TogglePanel();
        }
    }

    void TogglePause()
    {
        isGamePaused = !isGamePaused;

        if (isGamePaused)
        {
            Time.timeScale = 0f; // Pause the game
        }
        else
        {
            Time.timeScale = 1f; // Resume the game
        }
    }

    void TogglePanel()
    {
        if (panelToToggle != null)
        {
            panelToToggle.SetActive(!panelToToggle.activeSelf);
        }
    }
}
