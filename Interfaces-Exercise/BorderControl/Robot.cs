﻿using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    public Robot(string model,string id)
    {
        this.Model = model;
        this.Id = id;
    }
   string Model { get; set; }
   public string Id { get; set; }

}

