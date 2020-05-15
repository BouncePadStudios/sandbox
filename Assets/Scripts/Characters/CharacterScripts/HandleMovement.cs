using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleMovement : MonoBehaviour
{

    Rigidbody2D rb;
    StateManager states;
    HandleAnimations anim;

    public float acceleration = 30.0f;
    public float airAcceleration = 15.0f;
    public float maxSpeed = 60.0f;
    public float jumpSpeed = 4.0f;
    public float jumpDuration = 5.0f;
    float actualSpeed;
    bool justJumped;
    bool canVariableJump;
    float jumpTimer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        states = GetComponent<StateManager>();
        anim = GetComponent<HandleAnimations>();
        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        if(!states.dontMove)
        {
            HorizontalMovement();
            Jump();
        }
    }

    void HorizontalMovement()
    {
        actualSpeed = this.maxSpeed;

        if(!states.currentlyAttacking)
        {
            //rb.AddForce(new Vector2((states.horizontal * actualSpeed) - rb.velocity.x * this.acceleration, 0));
            //rb.AddForce(new Vector2((states.horizontal * actualSpeed) - rb.velocity.x * this.acceleration, rb.velocity.y));
            //rb.velocity = new Vector2(1.5f, rb.velocity.y);
            if (states.horizontal > 0.0f) // move right 
            {
                rb.velocity = new Vector2(1.5f, rb.velocity.y);


                // Change character position 
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (states.horizontal < -0.0f) // move left 
            {
                rb.velocity = new Vector2(-1.5f, rb.velocity.y);


                // Change character position
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else // no horizontal movement 
            {
                rb.velocity = new Vector2(0, rb.velocity.y);

            }
        }

        // Stop character if sliding  
        /*if (states.horizontal == 0 && states.onGround)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }*/
    }

    void Jump()
    {
        if(states.vertical > 0)
        {
            if (!justJumped && states.onGround) // old physics
            {
                anim.JumpAnim();

                rb.velocity = new Vector2(rb.velocity.x, 4f); 
                jumpTimer = 0;
                canVariableJump = true;
            }

            /*if (!justJumped)
            {
                justJumped = true;

                if (states.onGround)
                {

                    anim.JumpAnim();

                    rb.velocity = new Vector3(rb.velocity.x, this.jumpSpeed);
                    jumpTimer = 0;
                    canVariableJump = true;
                }
            }
            else
            {
                if (canVariableJump)
                {
                    jumpTimer += Time.deltaTime;

                    if (jumpTimer < this.jumpDuration / 1000)
                    {
                        rb.velocity = new Vector3(rb.velocity.x, this.jumpSpeed);
                    }
                }
            }*/
        } 
        else
        {
            justJumped = false;
        }
    }

    public void AddVelocityOnCharacter(Vector3 direction, float timer)
    {
        StartCoroutine(AddVelocity(timer, direction));
    }

    IEnumerator AddVelocity(float timer, Vector3 direction)
    {
        float t = 0;

        while (t < timer)
        {
            t += Time.deltaTime;

            //rb.velocity = direction;
            rb.AddForce(direction * 8); // knockback
            yield return null;
        }
    }
}
