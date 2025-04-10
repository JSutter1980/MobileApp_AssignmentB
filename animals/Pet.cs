public abstract class Pet
{
    protected string name;

    protected Pet(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }
}