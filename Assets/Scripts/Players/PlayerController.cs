﻿using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerInfo playerInfo;

    private Animator animator;
    private Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    GameObject[] attackHitBoxes = new GameObject[4];

    [SerializeField]
    private Transform groundCheck;

    [SerializeField]
    private Transform groundCheckL;

    [SerializeField]
    private Transform groundCheckR;

    // STORE THESE VALUES IN THE PLAYERINFO SCRIPTABLE OBJECT ATTACHED
    [SerializeField]
    private float runSpeed = 1.5f;

    [SerializeField]
    private float jumpSpeed = 4f;

    private float hitboxDuration = .5f;

    private float dashSpeed = 3f;

    private bool isAttacking = false;

    private bool isAirAttacking = false;

    private bool isGrounded;

    private bool isCrouched = false;

    private float horizontalAxis;
    private float verticalAxis;
    private bool attack;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnMove(float h, float v)
    {
        horizontalAxis = h;
        verticalAxis = v;

        animator.SetFloat("Speed", Mathf.Abs(horizontalAxis));
    }

    public void OnAttack()
    {
        if (!isAttacking)
        {
            isAttacking = true;
            int i;

            // Select the attack animation 
            if (isGrounded)
            {

                if (isCrouched)
                {
                    // Crouch attack
                    //animator.Play("Player_attack3");
                    i = 3;
                }
                else
                {
                    // Melee attack
                    i = Random.Range(1, 3);
                    //animator.Play("Player_attack" + i);
                }

            }
            else
            {
                // Aerial attack 
                //animator.Play("Player_attack4");
                isAirAttacking = true;
                i = 4;
            }

            i -= 1; // arrays start at 0 so convert to accomodate for that 
            StartCoroutine(DoAttack(i));
        }
    }

    public void OnJump()
    {
        if (isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            //animator.Play("Player_jump");
        }
    }

    IEnumerator DoAttack(int i)
    {
        attackHitBoxes[i].SetActive(true);
        yield return new WaitForSeconds(hitboxDuration);
        attackHitBoxes[i].SetActive(false);
        isAttacking = false;
    }

    private void FixedUpdate()
    {
        // Alters member value depending if the player is grounded or in the air 
        if ((Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))    ||
            (Physics2D.Linecast(transform.position, groundCheckL.position, 1 << LayerMask.NameToLayer("Ground")))   ||
            (Physics2D.Linecast(transform.position, groundCheckR.position, 1 << LayerMask.NameToLayer("Ground"))))
        {
            isGrounded = true;
            
            // Cancel air attack animation 
            if (isAirAttacking)
            {
                isAirAttacking = false;
                isAttacking = false;
            }
        }
        else
        {
            isGrounded = false;

            //if (!isAttacking)
            //    animator.Play("Player_jump");
        }

        if (horizontalAxis > 0.1f) // move right 
        {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);

            //if (isFree())
            //    animator.Play("Player_run");

            // Change character position 
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalAxis < -0.1f) // move left 
        {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);

            //if (isFree())
            //    animator.Play("Player_run");

            // Change character position
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else // no horizontal movement 
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);

            //if (isFree())
            //    animator.Play("Player_idle");
        }

    }

    private bool isFree()
    {
        if (isGrounded && !isAttacking && !isCrouched)
        {
            return true;
        }

        return false;
    }
}
