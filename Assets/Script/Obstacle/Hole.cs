using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject Lose;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Lose.SetActive(true);
            { Time.timeScale = 0; }
        }
    }
}
