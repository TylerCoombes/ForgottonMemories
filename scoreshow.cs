using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreshow : MonoBehaviour {

    public static int score;

    public Text text;

	// Use this for initialization
	void Awake ()
    {
        text = GetComponent <Text>();

        score = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "Score: " + score;
	}
}
