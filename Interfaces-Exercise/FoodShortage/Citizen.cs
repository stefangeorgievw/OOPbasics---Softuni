using System;
using System.Collections.Generic;
using System.Text;


public class Citizen:IBuyer
{
    public Citizen(string name, int age, string id,string birthday)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthday = birthday;
        this.Food =0;
    }

    public string Name { get; set; }
    int Age { get; set; }
   public  string Id { get; set; }
    public string Birthday { get; set; }
    int Food { get; set; }

    public int BuyFood()
    {
        return  10;
    }
}

