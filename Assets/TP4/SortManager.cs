using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SortManager : MonoBehaviour
{
    private int[] array = new int[6];

    [SerializeField] private TextMeshProUGUI result;

    public void setArray0(string number)
    {
        array[0] = int.Parse(number);
    }
    public void setArray1(string number)
    {
        array[1] = int.Parse(number);
    }
    public void setArray2(string number)
    {
        array[2] = int.Parse(number);
    }
    public void setArray3(string number)
    {
        array[3] = int.Parse(number);
    }
    public void setArray4(string number)
    {
        array[4] = int.Parse(number);
    }
    public void setArray5(string number)
    {
        array[5] = int.Parse(number);
    }

    public void Bubble()
    {
        ShowArray(Sort.BubbleSort(array, 0));
    }
    public void Quick()
    {
        ShowArray(Sort.QuickSort(array, 0, array.Length-1));
    }
    public void Selection()
    {
        ShowArray(Sort.Selection(array, 0));
    }

    private void ShowArray(int[] array)
    {
        result.text = array[0].ToString();
        for (int i = 1; i < array.Length; i++)
        {
            result.text += ", " + array[i];
        }
    }
}
