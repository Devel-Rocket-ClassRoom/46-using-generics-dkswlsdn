using System;
using System.Collections.Generic;
using System.Text;

public class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void SwapInArray<T>(T[] array, int index1, int index2)
    {
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        T min = array[0];

        foreach (T item in array)
        {
            min = item.CompareTo(min) < 0 ? item : min;
        }

        return min;
    }

    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        T max = array[0];

        foreach (T item in array)
        {
            max = item.CompareTo(max) > 0 ? item : max;
        }

        return max;
    }

    public static void Reverse<T>(T[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            SwapInArray(array, i, array.Length - 1 - i);
        }
    }
}