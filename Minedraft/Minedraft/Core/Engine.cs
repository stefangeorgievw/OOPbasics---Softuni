using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    internal void Run()
    {
        string command;
        DraftManager manager = new DraftManager();
        while ((command = Console.ReadLine()) != "Shutdown")
        {
            List<string> commandArgs = command.Split().ToList();
            switch (commandArgs[0])
            {
                case "RegisterHarvester":
                    commandArgs.RemoveAt(0);
                    Console.WriteLine(manager.RegisterHarvester(commandArgs));
                    break;
                case "RegisterProvider":
                    commandArgs.RemoveAt(0);
                    Console.WriteLine(manager.RegisterProvider(commandArgs));
                    break;
                case "Day":
                    commandArgs.RemoveAt(0);
                    Console.WriteLine(manager.Day());
                    break;
                case "Mode":
                    commandArgs.RemoveAt(0);
                    Console.WriteLine(manager.Mode(commandArgs));
                    break;
                case "Check":
                    commandArgs.RemoveAt(0);
                    Console.WriteLine(manager.Check(commandArgs));
                    break;



            }
        }

        Console.WriteLine(manager.ShutDown());

    }
}

