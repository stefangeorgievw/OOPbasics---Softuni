using System;
using System.Collections.Generic;
using System.Text;

public class Rebel : IBuyer
{
    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
        this.Food = 0;
    }
   public  string Name { get; set; }
    int Age { get; set; }
    int Food { get; set; }
    string Group { get; set; }

    public int BuyFood()
    {
        return 5;
    }
}

