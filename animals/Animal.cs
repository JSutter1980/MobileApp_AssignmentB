using System;
using System.Collections.Generic;

public class AnimalCreator
{
    private List<Talkable> zoo = new List<Talkable>();

    public void Run()
    {
        Console.WriteLine("What type of animal do you want to create? (Dog / Cat / Teacher): ");
        string choice = Console.ReadLine()?.Trim().ToLower();

        switch (choice)
        {
            case "dog":
                CreateDog();
                break;

            case "cat":
                CreateCat();
                break;

            case "teacher":
                CreateTeacher();
                break;

            default:
                Console.WriteLine("Unknown type.");
                break;
        }
    }

    private void CreateDog()
    {
        Console.Write("Enter the dog's name: ");
        string name = Console.ReadLine();

        Console.Write("Is the dog friendly? (true/false): ");
        bool isFriendly = bool.Parse(Console.ReadLine());

        zoo.Add(new Dog(isFriendly, name));
    }

    private void CreateCat()
    {
        Console.Write("Enter the cat's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the number of mice the cat has killed: ");
        int miceKilled = int.Parse(Console.ReadLine());

        zoo.Add(new Cat(miceKilled, name));
    }

    private void CreateTeacher()
    {
        Console.Write("Enter the teacher's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the teacher's age: ");
        int age = int.Parse(Console.ReadLine());

        zoo.Add(new Teacher(age, name));
    }

    public List<Talkable> GetZoo()
    {
        return zoo;
    }
}