using System;
using System.Collections.Generic;
using System.Text;

public class FireBender : Bender
{
    private double heatAggression;

    public double HeatAggression
    {
        get { return heatAggression; }
        private set { heatAggression = value; }
    }

    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public override double GetPower()
    {
        return this.HeatAggression * this.Power;
    }

    public override string ToString()
    {
        return $"Fire {base.ToString()}, Heat Aggression:{this.HeatAggression:f2}";
    }
}

