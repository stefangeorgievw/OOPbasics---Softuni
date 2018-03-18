using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var listOfCitizens = new List<Citizen>();
        var listOfRebels = new List<Rebel>();
        int result = 0;


        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            if (input.Length == 4)
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string id = input[2];
                string birthday = input[3];
                var citizen = new Citizen(name, age, id, birthday);
                listOfCitizens.Add(citizen);
            }
            if (input.Length == 3)
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                string group = input[2];
                var rebel = new Rebel(name, age, group);
                listOfRebels.Add(rebel);
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            foreach (var citizen in listOfCitizens)
            {
                if (citizen.Name == command)
                {
                    result += citizen.BuyFood();
                }
            }

            foreach (var rebel in listOfRebels)
            {
                if (rebel.Name == command)
                {
                    result += rebel.BuyFood();
                }
            }
        }
        Console.WriteLine(result);
    }
}

