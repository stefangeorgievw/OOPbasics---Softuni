using System;
using System.Collections.Generic;
using System.Text;


public class Citizen
{
    public Citizen(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }

    string Name { get; set; }
    int Age { get; set; }
   public  string Id { get; set; }
}

