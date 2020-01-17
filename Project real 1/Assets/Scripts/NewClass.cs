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
        Console.WriteLine(score);

        //m1m0 learning
        //boolean
        var newGame = true;
        Console.WriteLine(newGame);
        Console.WriteLine("Apples" == "Oranges");
        Console.WriteLine("Apples" == "Apples");
        var result = "Apples" == "Apples";
        result = "Apples" == "Oranges";
        Console.WriteLine(result);
        result = "Apples" != "Oranges";
        Console.WriteLine(result);
        result = "Apples" != "Apples";
        Console.WriteLine(result);
        Console.WriteLine(1 == 10);
        result = 10 == 10;
        Console.WriteLine(result);
        result = 1 != 10;
        Console.WriteLine(result);
        result = 1 < 10;
        Console.WriteLine(result);
        result = 1 > 10;
        Console.WriteLine(result);
        var number = 1;
        result = number == 10;
        Console.WriteLine(result);
        var password = "Swordfish";
        var loggedIn = password == "Swordfish";
        Console.WriteLine(loggedIn);
        if (true)
        {
            Console.WriteLine("Hi!");
        }

        var level = "Level 1";
        if (level == "Level 1")
        {
            Console.WriteLine("Starting Level 1");
        }

        score = 100;
        if (score == 100) ;
        {
            Console.Write("Game won!");
        }
        score = 50;
        if (score < 100) ;
        {
            Console.WriteLine("You need more points!");
        }
        score = 111;
        if (score > 100) ;
        {
            Console.WriteLine("New high score!");
        }
        level = "Level 2";
        if (level == "Level 3")
        {
            Console.WriteLine("Staring Level 3!");
        }
        else
        {
            Console.WriteLine("Level locked!");
        }

        score = 111;
        if (score < 100) ;
        {
            Console.WriteLine("Almost There!");
        }
        else
        {
            Console.WriteLine("You won!");
        }
        if ("Start" == "Start")
        {
            Console.WriteLine("Starting");
        }
        else
        {
            Console.WriteLine("Quitting");
        }

        var hour = 12;
        if (hour < 12)
        {
            Console.WriteLine("Good morning");
        }
        else if (hour < 17)
        {
            Console.WriteLine("Good afternoon");
        }

        score = 111;
        if (score < 100)
        {
            Console.WriteLine("Almost there!");
        }    
        else if (score > 100)
        {
            Console.WriteLine("Over 100!");
        }

        hour = 12;
        if (hour < 12)
        {
            Console.WriteLine("Good morning");
        }
        else if (hour < 17)
        {
            Console.WriteLine("Good afternoon");
        }
        else if (hour < 21)
        {
            Console.WriteLine("Good evening");
        }
        else
        {
            Console.WriteLine("Good night");
        }