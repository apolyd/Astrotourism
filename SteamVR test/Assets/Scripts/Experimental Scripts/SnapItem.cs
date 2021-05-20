using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SnapItem : MonoBehaviour
{

    public string TagName;
    public bool isSnaped;

    void Start()
    {
        isSnaped = false;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(TagName) && isSnaped == false)
        {
            Debug.Log("Item about to snap");
            if (other.GetComponent<Interactable>().attachedToHand == false)
            {
                other.transform.position = gameObject.transform.position;
                other.transform.rotation = gameObject.transform.rotation;
                Destroy(other.GetComponent<Throwable>());
                Destroy(other.GetComponent<Interactable>());
                other.GetComponent<Rigidbody>().isKinematic = true; //instead of destroy make it kinematic
                //Destroy(other.GetComponent<Rigidbody>()); //deleted part here
                //Destroy(other.gameObject);
                isSnaped = true;
                Debug.Log("Item is detached and should be snapped");
            }
        }
    }

}
