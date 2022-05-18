using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chaser : MonoBehaviour
{
    public GameObject player;
    public float MoveSpeed;
    public NavMeshAgent AI;
    public CapsuleCollider collision;
    public GameObject Lose;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
                AI.SetDestination(player.transform.position);
                if (AI.remainingDistance < AI.stoppingDistance)
                {
                    AI.speed = 0;
                }

        AI.updateRotation = false;
    }

    void OnTriggerEnter(Collider other) // Hit player then Lose screen pop up
    {
        if (other.tag == "Player")
        {
            Lose.SetActive(true);
            { Time.timeScale = 0; }
        }
    }
}
