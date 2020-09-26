using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen_BTN_Controll : MonoBehaviour
{
    public Canvas instruction_canvas;
    public Canvas LevelSelection_canvas;

    public void close_BTN()
    {
        instruction_canvas.enabled = false;
    }

    public void instruction_BTN()
    {
        instruction_canvas.enabled = true;
    }

    public void exit_BTN()
    {
        Application.Quit();
    }

    public void play_BTN()
    {
        LevelSelection_canvas.enabled = true;
    }

    public void close2_BTN()
    {
        LevelSelection_canvas.enabled = false;
    }

    // Scene Working
    public void L1_BTN()
    {
        SceneManager.LoadScene("lvl01");
    }

    public void L2_BTN()
    {
        SceneManager.LoadScene("lvl02");
    }

    public void L3_BTN()
    {
        SceneManager.LoadScene("lvl03");
    }

    public void L4_BTN()
    {
        SceneManager.LoadScene("lvl04");
    }

}
