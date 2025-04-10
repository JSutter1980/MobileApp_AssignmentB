using System;
using System.Collections.Generic;

public class MainClass
{
    private static readonly FileOutput outFile = new FileOutput("animals.txt");
    private static readonly FileInput inFile = new FileInput("animals.txt");

    public static void Main(string[] args)
    {
        List<Talkable> zoo = new List<Talkable>();

        
        zoo.Add(new Dog(true, "Bruno"));
        zoo.Add(new Cat(9, "Abbey"));
        zoo.Add(new Teacher(45, "Joe Sutter"));
        

        foreach (Talkable thing in zoo)
        {
            PrintOut(thing);
        }

        outFile.FileClose();
        inFile.FileRead();
        inFile.FileClose();

        FileInput indata = new FileInput("animals.txt");
        string line;
        while ((line = indata.FileReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }

    public static void PrintOut(Talkable p)
    {
        Console.WriteLine(p.GetName() + " says=" + p.Talk());
        outFile.FileWrite(p.GetName() + " | " + p.Talk());
    }
}