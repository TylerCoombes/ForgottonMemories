using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 0f;

	float horizontalMove = 0f;
    float verticalMove = 0f;
	private bool jump;
    public bool FacingRight = true;

    [SerializeField]
    private Rigidbody2D rb2d;

    // Update is called once per frame
    void Update () {

		/*horizontalMove = Input.GetAxis("Horizontal") * runSpeed;*/

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);
		}

        if (horizontalMove > 0 && !FacingRight)
        {
            //Bullet2.playerFace = true;
            Flip();
            //Bullet2.playerFace = true;
        }
        else if (horizontalMove < 0 && FacingRight)
        {
            Flip();
            //Bullet2.playerFace = false;
        }

    }

	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}

    private void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal");

        float verticalMove = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalMove, verticalMove);

        rb2d.AddForce(movement * runSpeed);
    }
    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -0.1f;
        transform.localScale = theScale;
    }

    public void checkDirection()
    {

    }

}
