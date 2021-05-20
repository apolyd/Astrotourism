using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ActionTest : MonoBehaviour
{
    public Hand hand;
    // Start is called before the first frame update
    void Start()
    {
        if(hand == null)
        {
            hand = this.GetComponent<Hand>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions.PistolTest.Shoot[hand.handType].state)
        {
            Debug.Log("Pew pew");
        }
    }
}
