using NeogamesTest.Services;
using NeogamesTest.Stores;

public class Program {     
    public static void Main(string[] args)
    {
        Console.WriteLine(new QualifiedBonusService(new DbRecordStore()).IsQualifyForBonus(1));
        Console.ReadLine();
    }
}