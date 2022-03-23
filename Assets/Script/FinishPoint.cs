using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public GameObject Win;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Win.SetActive(true);
            { Time.timeScale = 0; }
        }
    }
}
