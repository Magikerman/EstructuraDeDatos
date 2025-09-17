using System;
using UnityEngine;
using static UnityEditor.Progress;
public class SimpleList<T> : ISimpleList<T>
{
    public T[] array;
    const int defaultSize = 4;
    public T this[int index] { get {  return array[index]; } set { array[index] = value; } }

    private int count = 0;
    public int Count {  get { return count; } set { count = value; } }

    public SimpleList()
    {
        array = new T[defaultSize];
    }
    public SimpleList(int customSize)
    {
        array = new T[customSize];
    }
    public void Add(T item)
    {
        for (int i = 0; i < count + 1; i++)
        {
            if (i == count)
            {
                int previousLength = array.Length;
                var newArray = array;
                array = new T[array.Length * 2];
                for(int e = 0; e < newArray.Length; e++)
                {
                    array[e] = newArray[e];
                }
                array[i] = item;
                count++;
                break;
            }
            else if (array[i] == null)
            {
                array[i] = item;
                count++;
                break;
            }
        }
    }
    public void AddRange(T[] collection)
    {
        foreach (T item in collection)
        {
            if (item != null) { Add(item); }
        }
    }
    public bool Remove(T item)
    {
        bool removed = false;
        int index = -7;

        for (int i = count; i > -1; i--)
        {
            if (Equals(item, array[i]))
            {
                array[i] = default;
                removed = true;
                index = i;
                count--;
                break;
            }
        }

        if(removed)
        {
            for (int i = index; i < count; i++)
            {
                array[i] = array[i + 1];
            }
        }
        return removed;
    }

    public bool RemoveAt(int id)
    {
        bool removed = false;

        if (id < array.Length)
        {
            array[id] = default;
            removed = true;
        }

        if (removed)
        {
            for (int i = id; i < count; i++)
            {
                array[i] = array[i + 1];
            }
        }
        return removed;
    }

    public void Clear()
    {
        array = new T[defaultSize];
        count = 0;
    }
}
