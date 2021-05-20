using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FlyingTest : MonoBehaviour
{

    public NavMeshAgent agent;
    //public GameObject[] location;
   // public bool agentStatus;
    //private int loc;
    // Start is called before the first frame update
    void Start()
    {
        //loc = 0;
        //agent.isStopped = false;
        agent = GameObject.FindGameObjectWithTag("Drone").GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    //void Update()
    //{
    /*
    if (agentStatus)
    {
        agent.isStopped = false;
    }
    else
    {
        agent.isStopped = true;
    }
    agent.SetDestination(location[loc].transform.position);

    if(agent.remainingDistance <= 0.2f)
    {
        if (loc == 0)
            loc = 1;
        else
            loc = 0;

        agent.SetDestination(location[loc].transform.position);
    }
}
*/
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("bam");
        agent.isStopped = false;
        agent.updateRotation = true;
        agent.SetDestination(transform.position);
        Destroy(gameObject);
    }
}
