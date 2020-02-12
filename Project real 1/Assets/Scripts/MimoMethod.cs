using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimoMethod : MonoBehaviour

{

    void Start()
    {
        string str1 = "look at us";
        string str2 = "using a method!";
        string str3 = String.Concat(str1, str2);
    }

    static void SayHello()
    {
        throw new NotImplementedException();
    }

    {
        string s = "Hello World!";
        Console.WriteLine(s);
    }

    static int Triple(int n)
    {
        int result = n * 3;
        return result;
    }
    var number = Triple(3);
    Console.WriteLine (number);

    static void SayHello(string name)
    {
        string str1 = "Hello";
        string str2 = name;
        Console.WriteLine(str1 + str2);
    }

    SayHello("Hodor");

    int Multiply(int x, int y, int z)
    {
        int result = x * y * z;
        return result;
    }

    private int number = Multiply(1, 2, 3);
    Console.Writeline (number);

    private static int Factorial(int number)
    {
        int result;
        if (number == 1)
        {
            return 1;
        }
        else
        {
            result = Factorial(number - 1) * number;
            return result;
        }
    }

    private int factorial = Factorial(5);
    Console.WriteLine (factorial);
    
    static int Multiply (int i, int x = 3)
    {
        int result = i * x;
        return result;
    }

    private int product = Multiply(10);
    Console.WriteLine (product);
    
    static int Totalize(params int[] numbers);
    {
        int result = 0;
        foreach (int number in numbers)
        {
            result += number;
        }

        return result;
    }
    Totalize(1);
    Totalize(1, 2, 3);
    
        // Update is called once per frame
    void Update()
    {
        
    }
}
