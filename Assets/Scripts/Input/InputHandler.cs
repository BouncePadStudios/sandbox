using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private string horizontalAxis;
    private string verticalAxis;
    private string jumpButton;
    private string attackButton;
    //private string crouchButton;
    private string attack1Button;
    private int controllerNum;  //not used presently

    private bool usingControllers = false;

    float horizontal;
    float vertical;
    bool attack0;
    bool attack1;
    bool attack2;
    bool attack3;

    StateManager states; 

    // Start is called before the first frame update
    void Start()
    {
        states = GetComponent<StateManager>();        
    }

    public void SetupInput(string type, int id)
    {
        controllerNum = id;

        if (type == "C")
            usingControllers = true;

        horizontalAxis = type + "Horizontal" + id;
        verticalAxis = type + "Vertical" + id;
        jumpButton = type + "Jump" + id;
        attackButton = type + "Attack" + id;
        attack1Button = type + "AttackOne" + id;
        //crouchButton = type + "Crouch" + id;

    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis(horizontalAxis);
        vertical = Input.GetAxis(verticalAxis);
        attack0 = Input.GetButton(attackButton);
        attack1 = Input.GetButton(attack1Button);
        
        states.horizontal = horizontal;
        states.vertical = vertical;
        states.attack0 = attack0;
        states.attack1 = attack1;
    }
}
