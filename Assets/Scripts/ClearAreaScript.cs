using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearAreaScript : MonoBehaviour
{
    public float timeSinceLastTrigger = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastTrigger += Time.deltaTime;

        if (timeSinceLastTrigger > 1f)
        {
            Debug.Log("Clear Area");
        }
    }

    void OnTriggerStay()
    {
        timeSinceLastTrigger = 0f;
    }
}
