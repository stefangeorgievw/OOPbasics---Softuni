using System;
using System.Collections.Generic;
using System.Text;


public class Smartphone : ICallable, IBrowsable
{
    public Smartphone(string model)
    {
        this.Model = model;
    }
    string Model { get; set; }

    public string Browsing(string url)
    {
        if (Validator.IsUrlValid(url))
        {
            return $"Browsing: {url}!";
        }
        return "Invalid URL!";
    }

    public string Call(string phoneNumber)
    {
        if (Validator.IsNumberValid(phoneNumber))
        {
            return $"Calling... {phoneNumber}";
        }
        return "Invalid number!";
    }
}

