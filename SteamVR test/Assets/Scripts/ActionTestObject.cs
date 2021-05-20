using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class ActionTestObject : MonoBehaviour
{
    public SteamVR_ActionSet primaryset;
    public Interactable interactable;
    void OnAttachedToHand(Hand hand)
    {
        //Debug.Log("monkas"+hand.name.ToString());
        gameObject.transform.SetParent(hand.transform);
        if (interactable.attachedToHand)
        {

        }
    }
}
