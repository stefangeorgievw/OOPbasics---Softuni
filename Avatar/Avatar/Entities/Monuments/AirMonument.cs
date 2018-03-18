using System;
using System.Collections.Generic;
using System.Text;

public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name , int airAffinity):base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public int AirAffinity
    {
        get { return airAffinity; }
       private set { airAffinity = value; }
    }

    public override int GetAffinity()
    {
        return this.AirAffinity;
    }

    public override string ToString()
    {
        return $"Air {base.ToString()}, Air Affinity:{this.AirAffinity}";
    }

}

