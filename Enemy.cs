using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public int health = 100;
    public static int EnemyDmg = 10;
    public GameObject deathEffect;
    public static int healthAmount = 100;
    public static int scorevalue = 10;
    Rigidbody2D rb;

    Text score;


    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>();
    }

    public void TakeDamage (int damage)
     {
         health -= damage;

         if (health <= 0)
         {
             scoreshow.score += 10;
             Die();

         }
     }

        void Die()
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
}
