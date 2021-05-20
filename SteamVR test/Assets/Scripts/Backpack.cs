using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Backpack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parent;
    void Start()
    {
        
    }

    
    void OnTriggerStay(Collider other)
    {
      if (other.CompareTag("Backpack"))
      {
            Debug.Log("agizw");
         if (parent.GetComponent<Interactable>().attachedToHand == false)
         {
         Destroy(parent);
         }
           
      }            
    }
    
}
