using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private GameObject attackArea = default;

    private bool attacking = false;

    private float timeToAttack = 0.25f;
    private float timer = 0f;
   
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    void Update() // Key for attacking
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        }
        if(attacking) // Stop the attack when attack is finished
        {
            timer += Time.deltaTime;
            if(timer >= timeToAttack)
            {
                timer = 0;
                attacking = false;
                attackArea.SetActive(attacking);
            }
        }
    }

    private void Attack() // Set attack to true
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }
}
