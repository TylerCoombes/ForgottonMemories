using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseWorld : MonoBehaviour
{
    public static bool pauseworld = false;
    public GameObject pausemenu;
    public GameObject Gamecanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseworld)
            {
                resume();

                Gamecanvas.SetActive(true);
            }
            else
            {
                pause();
            }
        }
    }

    public void resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        pauseworld = false;
    }

    public void pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        pauseworld = true;
    }
}