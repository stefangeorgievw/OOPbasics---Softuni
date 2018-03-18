using System;
using System.Collections.Generic;
using System.Text;


public class Validator
{
    public static void ValidateName(string value)
    {
        if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Name cannot be empty");
        }
    }

    public static void ValidateMoney(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Money cannot be negative");
        }
    }
}
