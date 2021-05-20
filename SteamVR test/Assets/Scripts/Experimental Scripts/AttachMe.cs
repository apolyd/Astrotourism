using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class AttachMe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnHandHoverBegin(Hand hand)
    {
        hand.AttachObject(gameObject, GrabTypes.Grip, Hand.AttachmentFlags.ParentToHand | Hand.AttachmentFlags.TurnOnKinematic);
    }
}
