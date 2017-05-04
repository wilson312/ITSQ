using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MazeNavigation : MonoBehaviour {
    public Transform goal;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        goal = GameObject.Find("Goal").GetComponent<Transform>();
    }
    void Update()
    {
        agent.destination = goal.position;
    }
}
