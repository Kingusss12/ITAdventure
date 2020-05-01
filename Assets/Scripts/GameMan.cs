﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{
    public GameObject escapeCanvas;

    // Update is called once per frame
    void Update()
    {
        //If player push the "escape button, the player goes back to the MainScreen(Main Menu)"
        if (Input.GetKey(KeyCode.Escape))
        {
            OpenEscapeCanvas();
        }
    }

    public void BackToWorld()
    {
        AudioManager.playSelect();
        escapeCanvas.gameObject.SetActive(false);
        SceneManager.LoadScene("World");
    }

    public void ContinueLevel()
    {
        AudioManager.playSelect();
        escapeCanvas.gameObject.SetActive(false);
    }

    public void OpenEscapeCanvas()
    {
        AudioManager.playSelect();
        escapeCanvas.gameObject.SetActive(true);
    }
}
