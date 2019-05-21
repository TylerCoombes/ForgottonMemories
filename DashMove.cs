using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.RightShift))
            {
                direction = 2;
            }
        }
        else
        {
            if(dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb2d.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;
            }
            if(direction == 1)
            {
                rb2d.velocity = Vector2.left * dashSpeed;
            }
            else if(direction == 2)
            {
                rb2d.velocity = Vector2.right * dashSpeed;
            }
        }
    }
}
