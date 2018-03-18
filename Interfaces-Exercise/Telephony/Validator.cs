using System;
using System.Collections.Generic;
using System.Text;


public class Validator
{
    public static  bool IsNumberValid(string proneNumber)
    {
        for (int i = 0; i < proneNumber.Length; i++)
        {
            if (!char.IsDigit(proneNumber[i]))
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsUrlValid(string url)
    {
        for (int i = 0; i <url.Length; i++)
        {
            if (char.IsDigit(url[i]))
            {
                return false;
            }
        }
        return true;
    }
}

