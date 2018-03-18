using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var listOfBirthdays = new List<string>();
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var commandArgs = command.Split();
            if (commandArgs[0] == "Citizen")
            {
                string name = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                string id = commandArgs[3];
                string birthday = commandArgs[4];
                var citizen = new Citizen(name, age, id,birthday);
                listOfBirthdays.Add(citizen.Birthday);
            }
            if (commandArgs[0] == "Pet")
            {
                string name = commandArgs[1];
                string birthday = commandArgs[2];
                var pet = new Pet(name, birthday);
                listOfBirthdays.Add(pet.Birthday);
            }
        }

        string year = Console.ReadLine();

        foreach (var birthday in listOfBirthdays)
        {
            if (birthday.EndsWith(year))
            {
                Console.WriteLine(birthday);
            }
        }
    }
}

