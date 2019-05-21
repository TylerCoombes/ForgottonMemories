using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{

    public static int healthAmount = 100;
    public static int EnemyDmg = 25;
    public static int RockDmg = 50;
    public static int SpikeDmg = 100;
    Rigidbody2D rb;
    public Slider HealthBar;

    void Awake()
    {
        healthAmount = 100;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            Destroy(gameObject);
        }

        HealthBar.value = healthAmount;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Enemy"))
            healthAmount -= 10;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            healthAmount -= EnemyDmg;
        }

        if (col.gameObject.tag == "Rock")
        {
            healthAmount -= RockDmg;
        }

        if (col.gameObject.tag == "Potion" && healthAmount < 100)
        {
            healthAmount += 10;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Spike")
        {
            healthAmount -= SpikeDmg;
        }
        if (col.gameObject.tag == "Water")
        {
            healthAmount -= SpikeDmg;
        }

        if (healthAmount <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Game");
        }
    }
}
