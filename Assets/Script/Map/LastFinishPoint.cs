using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastFinishPoint : MonoBehaviour
{
    public GameObject Win;

    void Start()
    {
    }

    void OnTriggerEnter(Collider other) //Just like normal finish point but have a choice to go back to main menu
    {
        if (other.tag == "Player")
        {
            Win.SetActive(true);
            { Time.timeScale = 0; }
        }
    }
}
