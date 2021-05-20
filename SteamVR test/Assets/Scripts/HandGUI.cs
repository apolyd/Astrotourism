using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandGUI : MonoBehaviour
{
    public SkinnedMeshRenderer HandRender;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HandRender.enabled)
            GetComponent<Canvas>().enabled = true;
        else
            GetComponent<Canvas>().enabled = false;
    }
}
