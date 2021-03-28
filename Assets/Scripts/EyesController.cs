using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesController : MonoBehaviour
{
    private Camera thisCamera;
    private float defaultFOV;

    // Start is called before the first frame update
    void Start()
    {
        thisCamera = GetComponent<Camera>();
        defaultFOV = thisCamera.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Zoom"))
        {
            thisCamera.fieldOfView = defaultFOV / 1.5f;
        }
        else
        {
            thisCamera.fieldOfView = defaultFOV;
        }
    }
}
