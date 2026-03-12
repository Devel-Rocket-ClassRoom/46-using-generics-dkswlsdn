using System;
using System.Collections.Generic;
using System.Text;

public class Container<T>
{
    public T Value { get; set; }
}

public class SpecialConainer<T> : Container<T>
{
    public string Discription { get; set; }
}

public class IntContainer : Container<int>
{
    public int Double()
    {
        return Value * 2;
    }
}