using System;
using System.Collections.Generic;
using System.Text;

public class MyStack<T>
{
    private T[] stack;
    int _count;

    public int Count { get { return _count; } }
    public bool IsEmpty { get { return _count == 0; } }

    public MyStack(int catacity)
    {
        stack = new T[catacity]; 
        _count = 0;
    }


    public void Push(T item)
    {
        stack[_count] = item;
        _count++;
    }

    public T Pop()
    {
        return stack[--_count];
    }

    public T Peek()
    {
        return stack[_count - 1]; 
    }
}