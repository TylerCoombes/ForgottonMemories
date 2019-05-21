using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryText : MonoBehaviour
{

    public GameObject Text;
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Text.SetActive(true);
        }
    }

    public void OnTriggerExit2D()
    {
        Text.SetActive(false);
    }
}
