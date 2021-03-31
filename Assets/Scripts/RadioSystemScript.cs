using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystemScript : MonoBehaviour
{
    public AudioClip initialHeliCall;
    public AudioClip initialCallReply;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMakeInitialHeliCall()
    {
        audioSource.clip = initialHeliCall;
        audioSource.Play();

        Invoke("OnMakeCallReply", initialHeliCall.length + 1f);
    }

    void OnMakeCallReply()
    {
        audioSource.clip = initialCallReply;
        audioSource.Play();

        BroadcastMessage("OnDispatchHelicopter");
    }
}
