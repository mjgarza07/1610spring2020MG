using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class NewClass : MonoBehaviour
{
    // Start is called before the first frame update
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    
    private void Start()
    {
    print(nameString);
    print(intNum);
    print(floatNum);
    print(gameObj);
   
    //m1m0 learning
    var coins = 10;
    var coinValue = 5;
    var score = coins * coinValue;
    Console.WriteLine (score);
    
    }

}
