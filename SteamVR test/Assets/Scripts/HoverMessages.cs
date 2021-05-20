using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverMessages : MonoBehaviour
{
    //private GameObject HandDisplay;
    // Start is called before the first frame update
    void Start()
    {
        //HandDisplay = GameObject.FindGameObjectWithTag("PlayerHandDisplay");
    }

    public void ShowHoverMessage(string message)
    {
        GameObject.FindGameObjectWithTag("PlayerHandDisplay").GetComponent<MessagesHandler>().DisplayGlobalMessage(message);
    }

    public void ClearHoverMessage()
    {
        GameObject.FindGameObjectWithTag("PlayerHandDisplay").GetComponent<MessagesHandler>().DisplayGlobalMessage(" ");
    }

}
