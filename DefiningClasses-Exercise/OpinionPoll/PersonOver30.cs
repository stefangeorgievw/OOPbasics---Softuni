using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PersonOver30
{
    List<Person> people;

    public PersonOver30()
    {
        this.people = new List<Person>();

    }

    public void AddPerson(Person person)
    {
        this.people.Add(person);
    }

    public List<Person> GetOver30()
    {
        return this.people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
    }
}

