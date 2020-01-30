
using System;
using UnityEngine;

public class MimoStrings : MonoBehaviour
{
    public string stringName;

    void Start()

    private string stringName;
    {
        var place
        place = "New York";
        Console.WriteLine(place);
        char[] chars = {'a', 'b', 'c'};
        string word = new string(chars);
        Console.WriteLine(word);
        string str1 = "Hello!";
        string str2 = "Bill!";
        string str3 = String.Concat(srt1, srt2);
        Console.WriteLine(srt3);
        string hero = "Chuck Norris";
        Console.WriteLine(hero[4]);
        string name = "Bruce";
        int length = name.Length;
        Console.WriteLine(length);
        string s1 = "C# is such an amazing language";
        string s2 = "C#";
        bool b = s1.Contains(s2);
        Console.WriteLine(b);
        int index = s1.IndexOf("Aweseome");
        Console.WriteLine(index);
        string s1 = "Superman is the best ... not!";
        string s2 = s1.Remove(8);
        string s3 = s1.Remove(20);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        string s1 = "Aquaman is not better than Superman!";
        string s2 = s1.Remove(11, 16);
        string s3 = s1.Remove(11, 4);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        var s1 = "I'm such a bool bat!";
        var s2 = s1.Replace("b", "c");
        Console.WriteLine(s2);
        string s1 = "Silicon Valley";
        string s2 = s1.Remove(7);
        bool b = s1.Contains(s2);
        Console.WriteLine(b);
        string name = "John Wayne";
        name.Remove(5, 5);
        string s1 = "I,ve got the power!";
        string s2 = s1.Replace('p', 't');
        s2 = s2.Replace('r', 'l');
        Console.WriteLine(s2);
        


    }
    
    
}
