using System;
using System.Collections.Generic;
using System.Text;

public class Cup<T>
{
    public T value;

    public Cup(T t)
    {
        value = t;
    }
}