using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipDoor : MonoBehaviour
{
    public bool isCylinder;
    public Animator DoorAnim;
    public float LinearAngles;
    // Start is called before the first frame update
    void Start()
    {
        if(DoorAnim == null)   //check if we have attached an animator here
        {
            Debug.Log("There is no door animator attached.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float outputAngle = GetComponent<Valve.VR.InteractionSystem.CircularDrive>().outAngle; //get the current angles
        float normalized = outputAngle / 360f; //normalize output
        DoorAnim.SetFloat("Adjust", normalized);
    }
}
