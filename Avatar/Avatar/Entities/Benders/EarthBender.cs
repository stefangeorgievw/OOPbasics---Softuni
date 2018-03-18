using System;
using System.Collections.Generic;
using System.Text;

public class EarthBender : Bender
{
    private double groundSaturation;

    public double GroundSaturation
    {
        get { return groundSaturation; }
        private set { groundSaturation = value; }
    }

    public EarthBender(string name, int power, double groundSaturation) : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public override double GetPower()
    {
        return this.GroundSaturation * this.Power;
    }

    public override string ToString()
    {
        return $"Earth {base.ToString()}, Ground Saturation:{this.GroundSaturation:f2}";
    }
}

