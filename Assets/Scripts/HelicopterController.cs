using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    private bool called = false;
    private Rigidbody thisRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    void OnDispatchHelicopter()
    {
        thisRigidbody.velocity = new Vector3(0, 0, 50f);
        called = true;
    }
}
