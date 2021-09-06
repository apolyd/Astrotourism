using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class HandUI : MonoBehaviour
{
    public SteamVR_Action_Boolean UIHandle;
    public GameObject UIScreen;
    public bool UIstatus;
    // Start is called before the first frame update
    void Start()
    {
        UIstatus = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (UIHandle.GetStateUp(SteamVR_Input_Sources.Any))
        {
            if (UIstatus)
            {
                UIScreen.SetActive(false);
                UIstatus = false;
            }
            else
            {
                UIScreen.SetActive(true);
                UIstatus = true;
            }
        }
    }
}
