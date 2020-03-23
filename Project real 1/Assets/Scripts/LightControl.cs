
using System;
using UnityEngine;
[RequireComponent(typeof(Light))]
public class LightControl : MonoBehaviour
{
    private Light lightObj;


    void Start()
    {
     lightObj = GetComponent<Light>();
     lightObj.intensity = 0f;
    }



}
