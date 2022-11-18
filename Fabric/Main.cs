class Program
{
    public static void Main()
    {
        Factory concreteFactory = new Factory();
        Archer concreteArcher = concreteFactory.createArcher();
        Console.WriteLine(concreteArcher.getHealth());
        ObjectPool test = new ObjectPool();
        Console.WriteLine(test.archers[0].getWeapon());
    }
}