using System;
using System.Collections.Generic;
using System.Text;


public class Pet
{
    public Pet(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }
    string Name { get; set; }
   public string Birthday { get; set; }
}

