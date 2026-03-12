using System;
using System.Collections.Generic;
using System.Text;

public class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    private TKey[] keys;
    private TValue[] values;
    private int count;

    public int Count { get { return count; } }


    public Registry(int capacity)
    {
        keys = new TKey[capacity];
        values = new TValue[capacity];
        count = 0;
    }

    public void Register(TKey key, TValue value)
    {
        if (Contains(key))
        {
            for (int i = 0; i < count; i++)
            {
                if (key.Equals(keys[i]))
                {
                    values[i] = value;
                }
            }

            return;
        }

        if (count >= keys.Length)
        {
            return;
        }

        keys[count] = key;
        values[count] = value;
        count++;
    }

    public TValue Find(TKey key)
    {
        for (int i = 0; i < count; i++)
        {
            if (key.Equals(keys[i]))
            {
                return values[i];
            }
        }

        return default(TValue);
    }

    public bool Contains(TKey key)
    {
        for (int i = 0; i < count; i++)
        {
            if (key.Equals(keys[i]))
            {
                return true;
            }
        }

        return false;
    }

    public void PrintAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"[{keys[i]}] {Find(keys[i])}");
        }
    }
}