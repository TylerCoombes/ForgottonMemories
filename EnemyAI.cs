using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAI : MonoBehaviour
{

    public float speed;
    public GameObject Player;
    private float dazedTime;
    public float startDazedTime;
    public static int score = 0;
    private Transform target;
    public bool FindPlayer;
    public bool aggro;
    public Transform Circle;
    public float Check;
    public int health = 100;



    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (dazedTime <= 0)
        {
            speed = 5;
        }
        else
        {
            speed = 0;
            dazedTime -= Time.deltaTime;
        }

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }

        if (aggro == true)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (target.position.x > transform.position.x)
        {

            transform.localScale = new Vector2(-0.4f, 0.4f);
        }
        else if (target.position.x < transform.position.x)
        {

            transform.localScale = new Vector2(1, 1);
        }

        if (Physics2D.OverlapCircle(Circle.position, Check, LayerMask.GetMask("Player")))
        {
            aggro = true;
        }
        else
        {
            aggro = false;
        }
    }

        private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Circle.position, Check);
    }
        
}