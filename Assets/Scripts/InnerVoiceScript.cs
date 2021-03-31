using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoiceScript : MonoBehaviour
{
    public AudioClip whatHappened;
    public AudioClip goodLandingArea;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = whatHappened;
        audioSource.Play();
    }

    void OnFindClearArea()
    {
        audioSource.clip = goodLandingArea;
        audioSource.Play();

        Invoke("CallHeli", goodLandingArea.length + 1f);
    }

    void CallHeli()
    {
        SendMessageUpwards("OnMakeInitialHeliCall");
    }
}
