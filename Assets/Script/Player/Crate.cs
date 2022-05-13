using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    [SerializeField] private int health = 1;

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

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject, 0.3f);
        }
    }
}
