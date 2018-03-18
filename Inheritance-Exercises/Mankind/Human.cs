﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Human
{
    private string firstname;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public virtual string LastName
    {
        get { return this.lastName; }
        protected set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: lastName");
            }
            if (value.Length < 3)
            {
                throw new ArgumentException($"Expected length at least 3 symbols! Argument: lastName");
            }

            this.lastName = value;
        }
    }

    public string FirstName
    {
        get { return this.firstname; }
        protected set
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: firstName");
            }
            if (value.Length < 4)
            {
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: firstName");
            }

            this.firstname = value;
        }
    }
}

