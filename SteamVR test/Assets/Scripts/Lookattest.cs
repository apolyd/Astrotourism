using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Lookattest : MonoBehaviour
{
    public Transform focus;
    public NavMeshAgent agent;
    public GameObject Ingenuity;
    public Text pistolText;
    // Start is called before the first frame update
    void Start()
    {
        if (agent != null)
        {
            agent = GetComponent<NavMeshAgent>();
            agent.isStopped = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.isStopped || agent == null)
        {
            agent.updateRotation = false;
            Vector3 relativePos = focus.position - transform.position;
            relativePos.y = 0f;
            Quaternion toRotation = Quaternion.LookRotation(relativePos);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 1 * Time.deltaTime);
            pistolText.text = "Ingenuity is idle";//new code
        }
        else
        {
            pistolText.text = "Ingenuity is moving";//new code
            Ingenuity.GetComponent<IngenuityHandler>().turn = true;
            if (agent.remainingDistance <= 0.1f)
            {
                agent.isStopped = true;
                Ingenuity.GetComponent<IngenuityHandler>().turn = false;
                //agent.ResetPath();
            }
        }
        
    }
}
