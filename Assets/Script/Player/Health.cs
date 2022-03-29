using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int amount)
    {
        this.health -= amount;

        if (health <= 0)
        {
            Dead();
        }
    }

    public void Dead()
    {
        Destroy(gameObject);
    }
}
