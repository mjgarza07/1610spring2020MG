
using UnityEngine;
using UnityEngine.Events;

public class January : MonoBehaviour
{

    public float floatNumber;
    public int scoreValue;
    public UnityEvent uEvent;
    
    //start update triggers and events
    void Start()
    {
        uEvent.Invoke();
    }
    
    void Update()
    {
       
    }
}
