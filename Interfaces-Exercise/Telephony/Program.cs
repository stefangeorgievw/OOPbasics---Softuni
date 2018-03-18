using System;


public class Program
{
    static void Main(string[] args)
    {
        var smartphone = new Smartphone("Smartphone");
        var numbersToCall = Console.ReadLine().Split();
        foreach (var number in numbersToCall)
        {
            Console.WriteLine(smartphone.Call(number));
        }

        var sitesToBrowse = Console.ReadLine().Split();

        foreach (var site in sitesToBrowse)
        {
            Console.WriteLine(smartphone.Browsing(site));
        }
    }
}

