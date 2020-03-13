using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;

public class NameGenerator
{
    public Nationality nationality;
    public Sex sex;
    public string fullName;

    public NameGenerator(Nationality _nationality, Sex _sex)
    {
        nationality = _nationality;
        sex = _sex;
        
        string first = firstName();
        string last = lastName();
        fullName = first + " " + last;
    }
    
    public List<string> ReadNames(string fullPath)
    {
        //Read the text from directly from the test.txt file
        List<string> names = new List<string>();
        StreamReader reader = new StreamReader(fullPath);
        while (!reader.EndOfStream)
        {
            names.Add(reader.ReadLine());
        }
        reader.Close();
        return names;
    }

    public string lastName(Nationality _nationality)
    {
        List<string> surnames = ReadNames($"Assets/Resources/Portraits/{_nationality}/lastNames.txt");
        int count = surnames.Count;
        int j = Random.Range(0, count);
        return surnames[j];
    }

    public string lastName()
    {
        List<string> surnames = ReadNames($"Assets/Resources/Portraits/{nationality}/lastNames.txt");
        int count = surnames.Count;
        int j = Random.Range(0, count);
        return surnames[j];
    }

    public string firstName(Nationality _nationality, Sex _sex)
    {
        List<string> names = ReadNames($"Assets/Resources/Portraits/{_nationality}/{_sex}/firstNames.txt");
        int count = names.Count;
        int j = Random.Range(0, count);
        return names[j];
    }

    public string firstName()
    {
        List<string> names = ReadNames($"Assets/Resources/Portraits/{nationality}/{sex}/firstNames.txt");
        int count = names.Count;
        int j = Random.Range(0, count);
        return names[j];
    }
}
