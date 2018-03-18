﻿using System;
using System.Collections.Generic;
using System.Text;


public class StackOfStrings
{
    private List<string> data = new List<string>();

    public bool IsEmpty()
    {
        return data.Count <= 0;
    }

    public void Push(string item)
    {
        data.Add(item);
    }

    public string Pop()
    {
        string result = string.Empty;
        if (!IsEmpty())
        {
            
            result = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            
        }
        return result;

    }

    public string Peek()
    {
        string result = string.Empty;
        if (!IsEmpty())
        {
            result = data[data.Count - 1];
        }
        return result;

    }

}

