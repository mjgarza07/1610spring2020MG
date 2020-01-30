using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class MimoLists : MonoBehaviour
{
    public List listName;
    void Start()

    {
        List<double> times = new List<double>();
        times.Add(4.20);
        times.Add(7.30);
        times.Add(9.35);
        string s = String.Join(",", times);
        Console.WriteLine(s);
        var names = new List<string> ();
        names.Add("Peter");
        names.Add("Lois");
        names.Add("Meg");
        Console.WriteLine(names[0]);
        Console.WriteLine(names[2]);
        var ages = new List<int>();
        ages.Add(35);
        ages.Add(28);
        ages.Add(32);
        Console.WriteLine(ages.Count);
        var days = new List<string>();
        days.Add("Monday");
        days.Add("Wednesday");
        days.Insert(1,"Tuesday");
        s = String.Join(",", days);
        Console.WriteLine(s);
        var numbers = new List<int>();
        numbers.Add(6);
        numbers.Add(2);
        numbers.Add(0);
        numbers.Sort();
        s = String.Join(",", numbers);
        Console.WriteLine(s);
        var villains = new List<string>();
        villains.Add("Lex Luthor");
        villains.Add("Magento");
        villains.Add("Green Goblin");
        villains.Remove("Magneto");
        s = String.Join(",", villains);
        Console.WriteLine(s);
        var speeds = new List<int>();
        speeds.Add(37);
        speeds.Add(29);
        speeds.Add(6);
        var i = speeds.IndexOf(29);
        var j = speeds.IndexOf(66);
        Console.WriteLine(i);
        Console.WriteLine(j);
        int[] array = {1, 2, 3};
        var list = new List<string>(array);
        s = String.Join(",", list);
        Console.WriteLine(s);
        string[] colours = {"Red", "Blue", "Purple"};
        var colourList = new List<string>(colours);
        colourList.Insert(2,"Green");
        s = string.Join(",", colourList);
        Console.WriteLine(s);
        list = new List<string>();
        list.Add("Milk");
        
        
        

    }

}
