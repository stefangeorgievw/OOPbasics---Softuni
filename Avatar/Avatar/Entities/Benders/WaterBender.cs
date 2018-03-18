using System;
using System.Collections.Generic;
using System.Text;

public class WaterBender : Bender
{
    private double waterClarity;

    public double WaterClarity
    {
        get { return waterClarity; }
        private set { waterClarity = value; }
    }

    public WaterBender(string name, int power, double waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public override double GetPower()
    {
        return this.WaterClarity * this.Power;
    }


    public override string ToString()
    {
        return $"Water {base.ToString()}, WaterClarity:{this.WaterClarity:f2}";
    }
}

