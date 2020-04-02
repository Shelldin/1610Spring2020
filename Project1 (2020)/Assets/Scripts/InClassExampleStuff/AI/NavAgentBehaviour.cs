
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehaviour : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public Transform player;
    public float speed = 8f;
    private Transform currentDestination;
    public List<Transform> PatrolPoints;

    private int i;

    private bool canHunt;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = speed;
        currentDestination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        canHunt = true;
        currentDestination = player;
    }

    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
        currentDestination = transform;
    }

    void Update()
    {
        if (canHunt)
        {
            navMeshAgent.destination = currentDestination.position;
            return;
        }
        //navMeshAgent.destination = player.position;

        if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance< 0.5f)
        {
            navMeshAgent.destination = PatrolPoints[i].position;
            i = (i + 1) % PatrolPoints.Count;
        }
    }
}
