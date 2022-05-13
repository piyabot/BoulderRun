using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int dmg = 1;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<Crate>() != null)
        {
            Crate health = collider.GetComponent<Crate>();
            health.Damage(dmg);
        }
    }
}
