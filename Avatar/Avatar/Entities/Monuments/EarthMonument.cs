using System;
using System.Collections.Generic;
using System.Text;

public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity) : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public int EarthAffinity
    {
        get { return earthAffinity; }
        private set { earthAffinity = value; }
    }

    public override int GetAffinity()
    {
        return this.EarthAffinity;
    }

    public override string ToString()
    {
        return $"Earth {base.ToString()}, Earth Affinity:{this.EarthAffinity}";
    }
}

