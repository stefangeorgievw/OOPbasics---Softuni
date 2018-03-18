using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Engine
{
    NationsBuilder nations = new NationsBuilder();
    public void Run()
    {
        string command;

        while ((command = Console.ReadLine()) != "Quit")
        {
            var commandArgs = command.Split(' ').ToList();
            var  firstCommand = commandArgs[0];
            commandArgs.RemoveAt(0);
            switch (firstCommand)
            {
                case "Bender":

                    nations.AssignBender(commandArgs);
                    break;

                case "Monument":
                    nations.AssignMonument(commandArgs);
                    break;

                case "Status":
                    Console.WriteLine(nations.GetStatus(commandArgs[0]));
                    break;

                case "War":
                    nations.IssueWar(commandArgs[0]);
                    break;

            }

        }

        Console.WriteLine(nations.GetWarsRecord());
    }
}

