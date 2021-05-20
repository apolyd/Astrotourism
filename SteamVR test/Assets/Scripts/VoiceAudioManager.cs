using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum VACockpitState //states of the Voice cockpit
{
    WaitingForInitialization,
    FifteenToLand,
    TenToLand,
    FiveToLand,
    ShipLanded,
    killme
}

public class VoiceAudioManager : MonoBehaviour
{
    public AudioClip[] VACockpitClips;

    public VACockpitState state;
    public AudioSource cockpitVoice;

    // Start is called before the first frame update
    void Awake()
    {
        state = VACockpitState.WaitingForInitialization; //initial state
        cockpitVoice = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() //maybe it is not needed
    {
        
    }

    public void PlayNextClipInQueue()
    {
        cockpitVoice.PlayOneShot(cockpitVoice.clip);
        Debug.Log("mpika");
    }

    public void UpdateManager() //big switch to load the audio clips
    {
        switch (state)
        {
            case VACockpitState.WaitingForInitialization:
                cockpitVoice.clip = VACockpitClips[0]; //load the first clip here ("15 seconds to landing...")
                state = VACockpitState.FifteenToLand;
                Debug.Log("ela");
                break;
            case VACockpitState.FifteenToLand:
                cockpitVoice.clip = VACockpitClips[1];
                state = VACockpitState.TenToLand;
                break;
            case VACockpitState.TenToLand:
                cockpitVoice.clip = VACockpitClips[2];
                state = VACockpitState.FiveToLand;
                break;
            case VACockpitState.FiveToLand:
                cockpitVoice.clip = VACockpitClips[3];
                state = VACockpitState.ShipLanded;
                break;
            case VACockpitState.ShipLanded:
                cockpitVoice.clip = VACockpitClips[4];
                state = VACockpitState.killme;
                break;
            case VACockpitState.killme:
                Destroy(gameObject, cockpitVoice.clip.length);
                break;
        }
    }
}
