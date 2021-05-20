using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandingSequence : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform target;
    public GameObject door,HUDCanvas,VoiceAudioManager;
    public Text DoorTextStatus,MetersToTouchdown,HUDTextInfo,SpeedInfo;
    public RawImage DoorStatusImage;
    public Texture OpenTexture;
    public bool HUDIsActive;
    //public GameObject label, roversVisibility;

    void Start()
    {
        HUDIsActive = false;
        SpeedInfo.text = speed.ToString()+" m/s";
        VoiceAudioManager.GetComponent<VoiceAudioManager>().UpdateManager();
    }

    // Update is called once per frame
    void Update()
    {
        float DistanceToLand = Vector3.Distance(transform.position, target.position);
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);// calculate distance to move
        MetersToTouchdown.text = DistanceToLand.ToString()+" meters"; //update position on displays
        if (DistanceToLand <= 20f && HUDIsActive == false) // at 20 meters spam the initialization text on hud and turn HUD on
        {
            HUDCanvas.SetActive(true);
            HUDTextInfo.GetComponent<HUDMessages>().DisplayGlobalMessage("HUD is now active.");
            HUDIsActive = true;
        }

        if(DistanceToLand <= 15f && VoiceAudioManager.GetComponent<VoiceAudioManager>().state == VACockpitState.FifteenToLand)
        {
            VoiceAudioManager.GetComponent<VoiceAudioManager>().PlayNextClipInQueue();
            VoiceAudioManager.GetComponent<VoiceAudioManager>().UpdateManager();
        }

        if (DistanceToLand <= 10f && VoiceAudioManager.GetComponent<VoiceAudioManager>().state == VACockpitState.TenToLand)
        {
            VoiceAudioManager.GetComponent<VoiceAudioManager>().PlayNextClipInQueue();
            VoiceAudioManager.GetComponent<VoiceAudioManager>().UpdateManager();
        }

        if (DistanceToLand <= 5f && VoiceAudioManager.GetComponent<VoiceAudioManager>().state == VACockpitState.FiveToLand)
        {
            VoiceAudioManager.GetComponent<VoiceAudioManager>().PlayNextClipInQueue();
            VoiceAudioManager.GetComponent<VoiceAudioManager>().UpdateManager();
        }


        if (DistanceToLand <= 0.1f)
        {
            if(VoiceAudioManager.GetComponent<VoiceAudioManager>().state == VACockpitState.ShipLanded)
            {
                VoiceAudioManager.GetComponent<VoiceAudioManager>().PlayNextClipInQueue();
                VoiceAudioManager.GetComponent<VoiceAudioManager>().UpdateManager();
            }
            MetersToTouchdown.text = 0.ToString();
            GameObject.FindGameObjectWithTag("Player").transform.parent = null;
            door.GetComponent<DoorHandle>().hasLanded = true;
            DoorTextStatus.text = "Open";
            DoorStatusImage.texture = OpenTexture;
            //GameObject.FindGameObjectWithTag("Door").GetComponent<MeshCollider>().enabled = true;
            //label.SetActive(true);
            //roversVisibility.SetActive(true);

        }

    }
}
