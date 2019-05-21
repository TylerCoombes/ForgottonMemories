using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{

    public Text scoreText;

    void Update()
    {
        scoreText.text = "Your Final Score:" + scoreshow.score.ToString();
    }
}
