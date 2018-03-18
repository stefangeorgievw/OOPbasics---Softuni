using System;
using System.Collections.Generic;
using System.Text;

public class AirBender : Bender
{
    private double aerialIntegrity;


    public double AerialIntegrity
    {
        get { return aerialIntegrity; }
       private set { aerialIntegrity = value; }
    }

    public AirBender(string name, int power, double aerialIntegrity) : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override double GetPower()
    {
        return this.AerialIntegrity * this.Power;
    }

    public override string ToString()
    {
        return $"Air {base.ToString()}, Aerial Integrity:{this.AerialIntegrity:f2}";
    }
}

