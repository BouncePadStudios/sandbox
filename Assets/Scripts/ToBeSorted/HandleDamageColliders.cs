using UnityEngine;
using System.Collections;

public class HandleDamageColliders : MonoBehaviour
{
    public GameObject[] damageColliders;

    public enum DamageType
    {
        melee,
        range
    }

    public enum DCtype // have one for each position, not just top and bottom
    {
        bottom,
        top
    }

    StateManager states;

    private void Start()
    {
        states = GetComponent<StateManager>();
        CloseColliders();
    }

    public void OpenCollider(DCtype type, float delay, DamageType damageType)
    {
        //make sure the colliders are flipped with the character 
        switch (type)
        {
            case DCtype.bottom:
                StartCoroutine(OpenCollider(damageColliders, 0, delay, damageType));
                break;
            case DCtype.top:
                StartCoroutine(OpenCollider(damageColliders, 1, delay, damageType));
                break;
        }
        /*if(!states.lookRight)
        {
            switch (type)
            {
                case DCtype.bottom:
                    StartCoroutine(OpenCollider(damageColliders, 0, delay, damageType));
                    break;
                case DCtype.top:
                    StartCoroutine(OpenCollider(damageColliders, 1, delay, damageType));
                    break;
            }
        } else
        {
            damageColliders.flipX;
        }*/
    }


    IEnumerator OpenCollider(GameObject[] array, int index, float delay, DamageType damageType)
    {

        yield return new WaitForSeconds(delay);
        array[index].SetActive(true);
        array[index].GetComponent<DoDamage>().damageType = damageType;
    }

    public void CloseColliders() {
        for (int i = 0; i < damageColliders.Length; i ++)
        {
            damageColliders[i].SetActive(false);
        }
    }
}