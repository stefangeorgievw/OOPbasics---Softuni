using System;
using System.Collections.Generic;
using System.Text;

public abstract class Monument
{


    public Monument(string name)
    {
        this.Name = name;
    }

    public string Name { get; }




    public abstract int GetAffinity();

    public override string ToString()
    {
        return $"Monument: { this.Name}";
    }

}

