using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumAllBefore : MonoBehaviour
{
    public int SumAllBefore(int limite, int num)
    {
        if (num < limite - 1)
        {
            return (num + SumAllBefore(limite, num + 1));
        }
        else { return (num); }
    }
        
}
