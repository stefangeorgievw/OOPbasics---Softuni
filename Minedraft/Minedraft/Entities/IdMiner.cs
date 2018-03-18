using System;
using System.Collections.Generic;
using System.Text;


public abstract class IdMiner
{
    private string id;

    public IdMiner(string id)
    {
        this.Id = id;
    }


    public string Id
    {
        get { return id; }
       protected set { id = value; }
    }

}

