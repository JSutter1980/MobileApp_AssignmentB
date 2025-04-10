public abstract class Person
{
    private string name;

    protected Person(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}