using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class GunThrowable : Throwable
{
    //The Action you used to grab the weapon
    public SteamVR_Action_Boolean GunGrabAction, Shoot;
    //Mark, whether the weapon is currently held
    private bool isGrabbing = false;
    //Flag of the number of grabs,
    private int GrabCount = 0;
    //The hand currently holding the gun
    private Hand currentHand;
    public SteamVR_ActionSet activateActionSetOnAttach;
    //When the hand touches the gun
    protected override void OnAttachedToHand(Hand hand)
    {
        //Keep parent content
        base.OnAttachedToHand(hand);
        //Get the current hand
        currentHand = hand;
        activateActionSetOnAttach.Activate(hand.handType);
        Debug.Log("Attach");
    }

    protected override void OnDetachedFromHand(Hand hand)
    {
        base.OnDetachedFromHand(hand);
        //Empty the current hand
        hand = null;
        //activateActionSetOnAttach.Deactivate(hand.handType);
        Debug.Log("Detach");
    }

    protected override void HandAttachedUpdate(Hand hand)
    {
        if (isGrabbing)
        {
            //The parent class, let go of the code
            base.HandAttachedUpdate(hand);
            isGrabbing = false;
        }
    }

    public void Update()
    {
        Debug.Log(interactable.attachedToHand);

        //Only the current, when the object is touched
        if (interactable.attachedToHand)
        {
            //Detect, you picked up the event of the object Action
            if (GunGrabAction.GetStateUp(currentHand.handType))
            {
                Debug.Log("-----");

                //Count>1 The object has been captured currently
                if (GrabCount >= 1)
                {
                    isGrabbing = true;
                    GrabCount = 0;
                }
                //Grab count = 0, no object is currently grabbed
                else
                {
                    GrabCount++;
                }
            }

            if (Shoot.GetStateUp(currentHand.handType))
            {
                GetComponent<GunScript>().Fire();
            }
        }

    }

}