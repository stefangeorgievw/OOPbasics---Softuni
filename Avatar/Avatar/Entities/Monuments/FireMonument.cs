using System;
using System.Collections.Generic;
using System.Text;

public class FireMonument : Monument
{
    private int fireAffinity;

    public FireMonument(string name, int fireAffinity) : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    public int FireAffinity
    {
        get { return fireAffinity; }
        private set { fireAffinity = value; }
    }

    public override int GetAffinity()
    {
        return this.FireAffinity;
    }

    public override string ToString()
    {
        return $"Fire {base.ToString()}, Fire Affinity:{this.FireAffinity}";
    }
}

