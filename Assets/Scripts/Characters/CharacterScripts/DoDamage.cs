using UnityEngine;
using System.Collections;

public class DoDamage : MonoBehaviour
{
    // ADD THIS TO THE COLLIDERS THX

    StateManager states;

    public HandleDamageColliders.DamageType damageType;

    void Start()
    {
        states = GetComponentInParent<StateManager>();    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        StateManager otherState = other.GetComponentInParent<StateManager>();
        if (otherState)
        {
            if(otherState != states)
            {
                if(!otherState.currentlyAttacking) // prevents dealing damage if you are already dealt damage
                    otherState.TakeDamage(10, damageType);
                    
            }
        }
    }
}
