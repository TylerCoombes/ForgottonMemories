using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController2D : MonoBehaviour
{

    [Range(0f, 600f)]
    [SerializeField]
    private float JumpForce = 500f;
    [Range(0f, 600f)]
    [SerializeField]
    private float yVel;
    public Animator animator;
    public int runSpeed = 100;
    private SpriteRenderer SpRend;
    float horizontalMove = 20;
    bool jump = false;
    private bool isGrounded;
    private float jumpforce = 500f;
    [SerializeField]
    private LayerMask WhatIsGround;
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private float groundRadius = .2f;
    

    public int curHealth;
    public int maxHealth = 100;

    [SerializeField]
    private Rigidbody2D rb2d;
    //is the player facing right?

    void Start()
    {
        curHealth = maxHealth;
    }

    // Use this for initialization
    void Awake()
    {

        rb2d = GetComponent<Rigidbody2D>();
        SpRend = GetComponent<SpriteRenderer>();

        groundCheck = transform.Find("GroundCheck");
    }

    // Update is called once per frame


    public void Move(float move, bool jump)
    {

        if (jump)
        {
            rb2d.AddForce(new Vector2(0, JumpForce));
        }

    }

    void Update()
    {
        animator.SetFloat("IsJumping", yVel);
        yVel = Mathf.Abs(rb2d.velocity.y);

        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, LayerMask.GetMask("Ground"));

        if (horizontalMove > 0)
        {
            transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        }

        else if (horizontalMove < 0)
        {
            transform.localScale = new Vector3(-0.8f, 0.8f, 0.8f);
        }


        if (Input.GetButtonDown("Jump") && rb2d.velocity.y == 0)
        {
            jump = true;
        }

        if(curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        if(curHealth <= 0)
        {
            Die();
        }
    }

    void FixedUpdate()
    {
        Move(Time.fixedDeltaTime, jump);
        jump = false;

        isGrounded = false;
        Collider2D[] cols = Physics2D.OverlapCircleAll(groundCheck.position, groundRadius, WhatIsGround);
        for (int c = 0; c < cols.Length; c++)
        {
            if (cols[c].gameObject != gameObject)
            {
                isGrounded = true;
            }
        }
    }

    void Die()
    {
        //Restart
        Application.LoadLevel(Application.loadedLevel);
    }

    public void GroundMove(float move, bool jump)
    {
        if (isGrounded)
        {
            Vector2 maxVelocity = new Vector2(move * 10f, rb2d.velocity.y);
        }
        if (isGrounded && jump)
        {
            isGrounded = false;
            rb2d.AddForce(new Vector2(0, jumpforce));
        }
    }

}

