using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngenuityHandler : MonoBehaviour
{
    public float speed;
    public Transform from, to;
    public bool turn;

    void Start()
    {
        turn = false;
        speed = 20;
    }

    void Update()
    {
        if (turn)
            RotateDown(-20f);
        else
            RotateDown(0f);
    }
    

    public void RotateDown(float x)
    {
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(x, -180, 0), speed * Time.deltaTime);
    }
}
