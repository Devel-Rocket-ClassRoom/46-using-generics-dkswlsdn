using System;
using System.Collections.Generic;
using System.Text;

public class NumberContainer<T> where T : struct
{
    public T Value { get; set; }

    public NumberContainer(T value)
    {
        Value = value; 
    }
}