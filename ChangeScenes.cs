using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

    public void StartScene(int level)
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitScene(int level)
    {
        SceneManager.LoadScene("Title Sequence");
    }

    public void LeaderBoardScene(int level)
    {
        SceneManager.LoadScene("LeaderBoard");
    }
}
