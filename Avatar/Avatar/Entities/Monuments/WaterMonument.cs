﻿using System;
using System.Collections.Generic;
using System.Text;

public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public int WaterAffinity
    {
        get { return waterAffinity; }
        private set { waterAffinity = value; }
    }

    public override int GetAffinity()
    {
        return this.WaterAffinity;
    }

    public override string ToString()
    {
        return $"Water {base.ToString()}, Water Affinity:{this.WaterAffinity}";
    }
}

