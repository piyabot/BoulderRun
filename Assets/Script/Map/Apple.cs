using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.gameObject.TryGetComponent(out PlayerController collect));
            {
                collect.CollectApple();
                Debug.Log("A");
            }
            Destroy(gameObject);
        }
    }
}
