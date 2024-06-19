using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
    
public class AIScript : MonoBehaviour {
       
    public Transform goal;
       
    void Start () 
    {
        
        
    }

    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position; 
    }
}