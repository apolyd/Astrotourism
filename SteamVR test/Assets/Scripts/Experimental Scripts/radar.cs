using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radar : MonoBehaviour
{
    public Transform focus;
    public Transform phone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = focus.position - transform.position;
        //Debug.Log(relativePos);
        relativePos.y = 0f;
        //relativePos.z += phone.position.z;
        //relativePos.x = 0f; //phone.position.x;
        Quaternion toRotation = Quaternion.LookRotation(relativePos);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 1 * Time.deltaTime);
        

        
    }
}
