using System;

public class Pet
{
    public string Name { get; set; }

    public Pet(string name)
    {
        Name = name;
    }
}

public interface ITalkable
{
    string Talk();
}

public class Dog : Pet, ITalkable
{
    private bool friendly;

    public Dog(bool friendly, string name) : base(name)
    {
        this.friendly = friendly;
    }

    public bool IsFriendly()
    {
        return friendly;
    }

    public string Talk()
    {
        return "Bark";
    }

    public override string ToString()
    {
        return $"Dog: name={Name} friendly={friendly}";
    }
}