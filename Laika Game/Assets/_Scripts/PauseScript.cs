﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    public static bool isPaused = false;
    public GameObject PauseMenu;
    public GameObject PauseButtons;
    public GameObject options;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel")) {
            if (isPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume() {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause() {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void OptionsButton() {
        OpenOptions();
    }

    public void ReturnButton() {
        CloseOptions();
    }

    public void OpenOptions() {
        PauseButtons.SetActive(false);
        options.SetActive(true);
    }

    public void CloseOptions() {
        options.SetActive(false);
        PauseButtons.SetActive(true);
    }

    public void Quit() {
        Application.Quit();
        //SceneManager.LoadScene(1);
    }

}
