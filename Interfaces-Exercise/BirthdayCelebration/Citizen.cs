using System;
using System.Collections.Generic;
using System.Text;


public class Citizen
{
    public Citizen(string name, int age, string id,string birthday)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthday = birthday;
    }

    string Name { get; set; }
    int Age { get; set; }
   public  string Id { get; set; }
    public string Birthday { get; set; }
}

