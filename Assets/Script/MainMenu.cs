using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Lorong");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ToLab()
    {
        SceneManager.LoadScene("LabFisika");
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToMateri()
    {
        SceneManager.LoadScene("Materi");
    }
}
