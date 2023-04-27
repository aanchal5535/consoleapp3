using System;
using System.Collections;
using System.Reflection.Metadata;

class program
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add("ora", "oracle");
        ht.Add("vb", "vb.NET");
        foreach (DictionaryEntry d in ht)
        {
            Console.WriteLine(d.Key + " :" + d.Value + " ");
        }
        Console.ReadKey();
    }
}