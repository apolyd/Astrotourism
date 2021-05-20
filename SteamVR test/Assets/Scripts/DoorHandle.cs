using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandle : MonoBehaviour
{
    public bool hasLanded;
    public GameObject HUDTextInfo;
    [SerializeField]
    private bool isOpen;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        hasLanded = false;
        isOpen = false;
        if (GetComponent<Animator>())
            anim = GetComponent<Animator>();
        else
            Debug.Log("Nice there is no animator seriously.");
    }

    public void useDoor()
    {
        if (hasLanded)
        {
            anim.SetTrigger("useDoor");
            isOpen = !isOpen;
        }
        else
        {
            GameObject.FindGameObjectWithTag("PlayerHandDisplay").GetComponent<MessagesHandler>().DisplayGlobalMessage("Airlock Locked.");
            if(HUDTextInfo.activeInHierarchy)
            HUDTextInfo.GetComponent<HUDMessages>().DisplayGlobalMessage("Airlock is locked");
        }           
        
    }
}
