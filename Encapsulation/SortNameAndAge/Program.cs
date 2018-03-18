using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        var people = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split();
            try
            {
                var person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                people.Add(person);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
        var bonus = decimal.Parse(Console.ReadLine());
        people.ForEach(p => p.IncreaseSalary(bonus));
        people.ForEach(p => Console.WriteLine(p.ToString()));

    }
}

