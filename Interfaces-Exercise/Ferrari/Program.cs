using System;

public class Program
{
    static void Main(string[] args)
    {
        string driver = Console.ReadLine();
        ICar ferarri = new Ferrari(driver);
        Console.WriteLine(ferarri.ToString());
    }
}

