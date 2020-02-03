
using System;
using System.Collections.Generic;
using UnityEngine;

public class MimoDictionaries : MonoBehaviour
{

    void Start();
    internal class dict
    {
        public class Add;

        public Dictionary<string, int> Dict { get; } = new
        Dictionary<string, int>();

    private Dictionary<int, string> dict = new Dictionary<int, string>();
    {
    {23, "Michael"},
    {91, "Dennis"}
    }
    Dictionary<string, int> dict = new
    Dictionary<string, int> ();

    public dict(Dictionary<string, int> dict)
    {
        this.dict = dict;
    }
    {
    dict.Add ("Ebenezer", 11);
    dict.Add ("Pippin", 45);
    dict.Add("estella", 37);
    Console.Writeline (dict["Ebenezer"]);
    Console.Writeline (dict["estella"]);
    }
    Dictionary<string, string> dict = new
    Dictionary<string, string>()
        {
            "Bob" , "London"
        }
        {
            "Sain" , "New York"
        }
        public class Count
        {
        }
    };
    Console.WriteLine (dict.Count);
    
    var dict = new Dictionary<int, string>()
        {
            {4, "Locke"};
            (8, "Reyes"};
        };
    var s = String.Join (",", dict.Keys);
    Console.Writeline (s);
    
    var dict = new Dictionary<int, string>();
    dict.add(15, "Ford");
    var dict = new Dictionary<string,string>()
        {
            {"Flower", "power"}
            {"Hubble", "Bubble"}
        };
    dict.Clear();
    Console.Writeline (dict.Count)
    var cSharp = new Dictionary<string, bool>()
        {
            {"Fun", true}
            {"Boring" , false}
        };
    cSharp.Remove ("Boring");
    var s = String.Join ("," , cSharp);
    Console.Writeline (s);
    


}
