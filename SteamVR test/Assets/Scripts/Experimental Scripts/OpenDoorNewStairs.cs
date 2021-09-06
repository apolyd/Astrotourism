using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorNewStairs : MonoBehaviour
{
    public Animator anim;

    public void OpenDoorWithStairs()
    {
        anim.SetTrigger("OpenDoor");
    }
}
