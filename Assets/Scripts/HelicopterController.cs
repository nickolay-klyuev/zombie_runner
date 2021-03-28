using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    public AudioClip callSound;

    private bool called = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("CallHeli") && !called)
        {
            called = true;
            print("Heli called");
        }
    }
}
