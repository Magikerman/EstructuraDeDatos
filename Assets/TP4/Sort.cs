using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class Sort
{
    //QuickSort
    static public int[] QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(array, low, high);

            QuickSort(array, low, pivot - 1);
            return QuickSort(array, pivot + 1, high);
        }
        else
        {
            return array;
        }
    }

    static public int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);
        return i + 1;
    }

    //BubbleSort
    static public int[] BubbleSort(int[] array, int sorted)
    {
        if (sorted >= array.Length)
        {
            return array;
        }
        else
        {
            sorted = CheckAll(array, sorted);

            return BubbleSort(array, sorted);
        }
    }

    static public int CheckAll(int[] array, int sorted)
    {
        for (int i = 1; i < array.Length - sorted; i++)
        {
            if (array[i-1] > array[i])
            {
                Swap(array, i - 1, i);
            }
        }
        sorted++;
        return sorted;
    }

    //Selection Sort
    static public int[] Selection(int[] array, int sorted)
    {
        int lowest = sorted;
        for (int i = sorted + 1; i < array.Length; i++)
        {
            if (array[i] < array[lowest])
            {
                lowest = i;
            }
        }
        Swap(array, lowest, sorted);
        sorted++;

        if (sorted >= array.Length)
        {
            return array;
        }
        else
        {
            return Selection(array, sorted);
        }
    }

    static public void Swap(int[] array, int A, int B)
    {
        int B2 = array[B];
        array[B] = array[A];
        array[A] = B2;
    }
}
