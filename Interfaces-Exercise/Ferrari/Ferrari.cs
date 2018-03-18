using System;
using System.Collections.Generic;
using System.Text;

public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        this.Driver = driver;
    }
    public string Model => "488-Spider";
    public string Driver { get;private set;}

    public string Brakes()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brakes()}/{this.Gas()}/{this.Driver}";
    }


}

