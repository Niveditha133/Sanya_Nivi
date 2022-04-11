using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public GameObject Goal;
    private NavMeshAgent agent;

    //private Boid _boid;
    //private Vector3 _goalPos;

    // Start is called before the first frame update
    private void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(Goal.transform.position);        
    }

    /*void Update()
    {
        _boid = GetComponent<Boid>();
    }*/

    //once it reaches the goal get boid script and flock 
}
