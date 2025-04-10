class Program
{
    static void Main(string[] args)
    {
        AnimalCreator creator = new AnimalCreator();
        creator.Run();

        List<Talkable> zoo = creator.GetZoo();

        foreach (Talkable animal in zoo)
        {
            Console.WriteLine($"{animal.GetName()} says: {animal.Talk()}");
        }
    }
}