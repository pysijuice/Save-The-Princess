using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private Transform princess;
    private NavMeshAgent agent;
    void Start()
    {
        princess = GameObject.FindWithTag("Princess").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = princess.position;

    }
}
