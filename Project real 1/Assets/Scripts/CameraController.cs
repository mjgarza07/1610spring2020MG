using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    public Camera cameraObj;
    void Start()
    {
        cameraObj = GetComponent<Camera>();
        cameraObj.depth = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
