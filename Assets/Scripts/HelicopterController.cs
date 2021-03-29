using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    public AudioClip callSound;

    private bool called = false;
    private AudioSource audioSource;
    private Rigidbody thisRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        thisRigidbody = GetComponent<Rigidbody>();
    }

    public void Call()
    {
        if (!called)
        {
            called = true;
            audioSource.clip = callSound;
            audioSource.Play();
            thisRigidbody.velocity = new Vector3(0, 0, 50f);
        }
    }
}
