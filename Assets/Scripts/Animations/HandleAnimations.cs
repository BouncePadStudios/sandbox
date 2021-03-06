﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleAnimations : MonoBehaviour
{

    public Animator anim;
    StateManager states;

    public float attackRate = .1f;
    public AttacksBase[] attacks = new AttacksBase[2];

    // Start is called before the first frame update
    void Start()
    {
        states = GetComponent<StateManager>();
        anim = GetComponentInChildren<Animator>();
    }

    private void FixedUpdate()
    {
        states.dontMove = anim.GetBool("DontMove");

        anim.SetBool("TakesHit", states.gettingHit);
        anim.SetBool("InAir", !states.onGround);
        anim.SetBool("IsCrouching", states.crouch);

        float movement = Mathf.Abs(states.horizontal);

        anim.SetFloat("Speed", movement);

        if(states.onGround && states.vertical < 0)
        {
            states.crouch = true;
        }
        else
        {
            states.crouch = false;
        }

        HandleAttacks();
    }

    void HandleAttacks()
    {
        if(states.canAttack)
        {

            // Melee attack 
            if (states.attack0)
            {
                attacks[0].attack = true;
                attacks[0].attackTimer = 0;
                attacks[0].timesPressed++;
            }

            if(attacks[0].attack)
            {
                attacks[0].attackTimer += Time.deltaTime;

                if (attacks[0].attackTimer > attackRate) // Reset the attackif (attacks[0].attackTimer > attackRate || attacks[0].timesPressed >= 3) // Reset the attack
                {
                    attacks[0].attack = false;
                    attacks[0].attackTimer = 0;
                    attacks[0].timesPressed = 0;
                }
            }

            // Ranged attack
            if (states.attack1)
            {
                attacks[1].attack = true;
                attacks[1].attackTimer = 0;
                attacks[1].timesPressed++;
            }

            if (attacks[1].attack)
            {
                attacks[1].attackTimer += Time.deltaTime;

                if (attacks[1].attackTimer > attackRate || attacks[1].timesPressed >= 3) // Reset the attack
                {
                    attacks[1].attack = false;
                    attacks[1].attackTimer = 0;
                    attacks[1].timesPressed = 0;
                }
            }

        }

        anim.SetBool("Attack0", attacks[0].attack);
        anim.SetBool("Attack1", attacks[1].attack);
    }

    public void JumpAnim()
    {
        anim.SetBool("Attack0", false);
        anim.SetBool("Attack1", false);

        anim.SetBool("IsJumping", true);
        StartCoroutine(CloseBoolInAnim("IsJumping"));
        /*if (states.onGround)
        {
            anim.SetBool("Attack0", false);
            anim.SetBool("Attack1", false);

            anim.SetBool("InAir", true);
            anim.SetBool("IsJumping", true);
        }*/
    }
    
    IEnumerator CloseBoolInAnim(string name)
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetBool(name, false);
    }
}

[System.Serializable]
public class AttacksBase
{
    public bool attack;
    public float attackTimer;
    public int timesPressed;
}