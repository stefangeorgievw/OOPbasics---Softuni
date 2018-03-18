using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var listOfIds = new List<string>();
        string command;
        while ((command = Console.ReadLine()) != "End" )
        {
            var commandArgs = command.Split();
            if (commandArgs.Length == 3)
            {
                string name = commandArgs[0];
                int age = int.Parse(commandArgs[1]);
                string id = commandArgs[2];
                var citizen = new Citizen(name, age, id);
                listOfIds.Add(citizen.Id);
            }
            if (commandArgs.Length == 2)
            {
                string model = commandArgs[0];
                string id = commandArgs[1];
                var robot = new Robot(model, id);
                listOfIds.Add(robot.Id);
            }
        }

        string numberEnds = Console.ReadLine();

        foreach (var id in listOfIds)
        {
            if (id.EndsWith(numberEnds))
            {
                Console.WriteLine(id);
            }
        }
    }
}

