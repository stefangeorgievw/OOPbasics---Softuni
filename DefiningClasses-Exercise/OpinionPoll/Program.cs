using System;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PersonOver30 personOver30 = new PersonOver30();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                int age = int.Parse(input[1]);
                personOver30.AddPerson(new Person(name, age));

            }

            var list = personOver30.GetOver30();
            foreach (var person in list)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
