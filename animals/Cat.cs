using System;

public interface ITalkable
{
    string Talk();
}

public class Pet
{
    protected string Name;

    public Pet(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }
}

public class Cat : Pet, ITalkable
{
    private int mousesKilled;

    public Cat(int mousesKilled, string name) : base(name)
    {
        this.mousesKilled = mousesKilled;
    }

    public int GetMousesKilled()
    {
        return mousesKilled;
    }

    public void AddMouse()
    {
        mousesKilled++;
    }

    public string Talk()
    {
        return "Meow";
    }

    public override string ToString()
    {
        return $"Cat: name={Name} mousesKilled={mousesKilled}";
    }
}