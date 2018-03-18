using System;
using System.Collections.Generic;
using System.Text;

public abstract class Bender
{
    
    private int power;

    public Bender(string name, int power)
    {
        this.Name = name;
        this.power = power;
    }

    public int Power
    {
        get { return power; }
       protected set { power = value; }
    }


    public string Name { get; }
   

    public abstract double GetPower();

    public override string ToString()
    {
        return $"Bender: { this.Name}, Power: { this.Power}";
    }

}

