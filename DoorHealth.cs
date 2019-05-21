using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHealth : MonoBehaviour
{

    public static int doorhealth = 20;
    public static int PlayerDmg = 10;


    void Update()
    {

        if (doorhealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

     void OnTriggerEnter2D()
    {
        doorhealth -= PlayerDmg;
    }
}
