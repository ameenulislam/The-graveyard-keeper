using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uimanager : MonoBehaviour
{
    public Animator settingsPanel;
    public Animator helpPanel;
    public AudioSource btnClick;

    public void settings()
    {
        settingsPanel.SetInteger("state", 1);
        btnClick.Play();
    }
    public void closeSettings()
    {
        settingsPanel.SetInteger("state", 2);
        btnClick.Play();
    }
    public void openHelp()
    {
        helpPanel.SetInteger("tohelp", 1);
        btnClick.Play();
    }

    public void closeHelp()
    {
        helpPanel.SetInteger("tohelp", 3);
        btnClick.Play();
    }

    public void openMain()
    {
        Application.LoadLevel(0);
        btnClick.Play();
    }

    public void openGame()
    {
        Application.LoadLevel(1);
        btnClick.Play();
    }

    public void endGame()
    {
        Application.Quit();
    }
}
