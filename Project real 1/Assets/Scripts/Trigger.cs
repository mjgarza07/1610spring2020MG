using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    void Start()
    {
    }

    public int scoreValue ;
    public float floatNumber;
    public string lightIntensity ;
    private UnityEvent uEvent;
    private UnityEvent tEvent;
    private UnityEvent iEvent;

    public Trigger(UnityEvent uEvent, UnityEvent tEvent, UnityEvent iEvent)
    {
        this.uEvent = uEvent;
        this.tEvent = tEvent;
        this.iEvent = iEvent;
    }


    private void OnTriggerEnter(Collider other)
    {
        uEvent.Invoke();
    }
    private void OnTriggerExit()
    {
        tEvent.Invoke();
    }

    private void OnTriggerStay()
    {
        iEvent.Invoke();
    }
}
