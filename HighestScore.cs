using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighestScore : MonoBehaviour
{

    public int HscoreValue;
    public Text HighScore;

    // Use this for initialization
    void Start()
    {

        HighScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore: ", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {

        HscoreValue = scoreshow.score;

        if (PlayerPrefs.GetInt("HighScore: ") < HscoreValue)
        {
            PlayerPrefs.SetInt("HighScore: ", HscoreValue);
            HighScore.text = "HighScore: " + HscoreValue.ToString();
        }

    }


    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        HighScore.text = "0";
    }
}

